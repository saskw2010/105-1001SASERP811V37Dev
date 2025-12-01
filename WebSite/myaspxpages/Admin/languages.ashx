<%@ WebHandler Language="C#" Class="LanguagesHandler" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Configuration;
using System.Linq;

/// <summary>
/// ASHX Handler for Language Settings API
/// Supports GET (retrieve all languages) and POST (bulk save)
/// </summary>
public class LanguagesHandler : IHttpHandler
{
    private string ConnectionString => ConfigurationManager.ConnectionStrings["eZee"].ConnectionString;

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "application/json";
        context.Response.Cache.SetCacheability(HttpCacheability.NoCache);

        try
        {
            string method = context.Request.HttpMethod.ToUpper();

            switch (method)
            {
                case "GET":
                    HandleGet(context);
                    break;
                case "POST":
                    HandlePost(context);
                    break;
                default:
                    SendError(context, "Method not allowed. Use GET or POST.", 405);
                    break;
            }
        }
        catch (Exception ex)
        {
            SendError(context, $"Server error: {ex.Message}", 500);
            System.Diagnostics.Debug.WriteLine($"LanguagesHandler Error: {ex}");
        }
    }

    /// <summary>
    /// GET: Retrieve all languages from database
    /// Response: { success: true, data: [...], timestamp: "ISO date", statistics: {...} }
    /// </summary>
    private void HandleGet(HttpContext context)
    {
        EnsureTableExists();

        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand(@"
                SELECT 
                    LanguageCode as code,
                    IsEnabled as enabled,
                    DisplayName as displayName,
                    DisplayNameArabic as displayNameArabic,
                    NativeName as nativeName,
                    Flag as flag,
                    IsRTL as isRTL,
                    LanguageGroup as [group],
                    IsNew as isNew,
                    SortOrder as sortOrder
                FROM LanguageSettings
                ORDER BY SortOrder, LanguageCode
            ", conn);

            var languages = new List<Dictionary<string, object>>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var lang = new Dictionary<string, object>
                    {
                        ["code"] = reader["code"].ToString(),
                        ["enabled"] = Convert.ToBoolean(reader["enabled"]),
                        ["displayName"] = reader["displayName"].ToString(),
                        ["displayNameArabic"] = reader["displayNameArabic"].ToString(),
                        ["nativeName"] = reader["nativeName"].ToString(),
                        ["flag"] = reader["flag"].ToString(),
                        ["isRTL"] = Convert.ToBoolean(reader["isRTL"]),
                        ["group"] = reader["group"].ToString(),
                        ["isNew"] = Convert.ToBoolean(reader["isNew"])
                    };
                    languages.Add(lang);
                }
            }

            var statistics = new Dictionary<string, object>
            {
                ["total"] = languages.Count,
                ["enabled"] = languages.Count(l => (bool)l["enabled"]),
                ["disabled"] = languages.Count(l => !(bool)l["enabled"])
            };

            var response = new Dictionary<string, object>
            {
                ["success"] = true,
                ["data"] = languages,
                ["statistics"] = statistics,
                ["timestamp"] = DateTime.UtcNow.ToString("o")
            };

            SendJson(context, response);
        }
    }

    /// <summary>
    /// POST: Bulk save language states
    /// Expects: { languages: [{code: "en-US", enabled: true}, ...] }
    /// Response: { success: true, updated: 5, timestamp: "ISO date" }
    /// </summary>
    private void HandlePost(HttpContext context)
    {
        try
        {
            EnsureTableExists();

            var serializer = new JavaScriptSerializer();
            string json = new System.IO.StreamReader(context.Request.InputStream).ReadToEnd();
            
            System.Diagnostics.Debug.WriteLine($"Received JSON: {json}");
            
            var payload = serializer.Deserialize<Dictionary<string, object>>(json);

            if (!payload.ContainsKey("languages"))
            {
                SendError(context, "Missing 'languages' property in request body", 400);
                return;
            }

            var languagesArray = payload["languages"] as System.Collections.ArrayList;
            if (languagesArray == null)
            {
                SendError(context, "Invalid 'languages' format", 400);
                return;
            }
            
            int updatedCount = 0;

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (Dictionary<string, object> lang in languagesArray)
                        {
                            string code = lang["code"].ToString();
                            bool enabled = Convert.ToBoolean(lang["enabled"]);

                            var cmd = new SqlCommand(@"
                                UPDATE LanguageSettings 
                                SET IsEnabled = @enabled, LastModified = GETDATE()
                                WHERE LanguageCode = @code
                            ", conn, transaction);

                            cmd.Parameters.AddWithValue("@code", code);
                            cmd.Parameters.AddWithValue("@enabled", enabled);

                            updatedCount += cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        var response = new Dictionary<string, object>
                        {
                            ["success"] = true,
                            ["updated"] = updatedCount,
                            ["timestamp"] = DateTime.UtcNow.ToString("o")
                        };

                        SendJson(context, response);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Diagnostics.Debug.WriteLine($"Transaction error: {ex}");
                        throw new Exception($"Transaction failed: {ex.Message}", ex);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"HandlePost error: {ex}");
            SendError(context, $"Save failed: {ex.Message}\nStack: {ex.StackTrace}", 500);
        }
    }

    /// <summary>
    /// Ensure LanguageSettings table exists (auto-create on first request)
    /// </summary>
    private void EnsureTableExists()
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var checkCmd = new SqlCommand(@"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LanguageSettings')
                BEGIN
                    CREATE TABLE LanguageSettings (
                        LanguageCode NVARCHAR(20) NOT NULL PRIMARY KEY,
                        IsEnabled BIT NOT NULL DEFAULT 1,
                        DisplayName NVARCHAR(100) NULL,
                        DisplayNameArabic NVARCHAR(100) NULL,
                        NativeName NVARCHAR(100) NULL,
                        Flag NVARCHAR(10) NULL,
                        IsRTL BIT NOT NULL DEFAULT 0,
                        LanguageGroup NVARCHAR(50) NULL,
                        IsNew BIT NOT NULL DEFAULT 0,
                        SortOrder INT NULL,
                        LastModified DATETIME NOT NULL DEFAULT GETDATE(),
                        ModifiedBy NVARCHAR(100) NULL
                    );
                    
                    -- Insert default data (matching the SQL script)
                    INSERT INTO LanguageSettings 
                        (LanguageCode, IsEnabled, DisplayName, DisplayNameArabic, NativeName, Flag, IsRTL, LanguageGroup, IsNew, SortOrder)
                    VALUES
                        (N'en-US', 1, N'English (United States)', N'الإنجليزية (أمريكا)', N'English', N'🇺🇸', 0, N'primary', 0, 1),
                        (N'ar-KW', 1, N'Arabic (Kuwait)', N'العربية (الكويت)', N'العربية', N'🇰🇼', 1, N'primary', 0, 2),
                        (N'fr-FR', 1, N'French', N'الفرنسية', N'Français', N'🇫🇷', 0, N'european', 0, 3),
                        (N'de-DE', 1, N'German', N'الألمانية', N'Deutsch', N'🇩🇪', 0, N'european', 0, 4),
                        (N'es-ES', 1, N'Spanish', N'الإسبانية', N'Español', N'🇪🇸', 0, N'european', 0, 5),
                        (N'it-IT', 1, N'Italian', N'الإيطالية', N'Italiano', N'🇮🇹', 0, N'european', 0, 6),
                        (N'pt-BR', 1, N'Portuguese (Brazil)', N'البرتغالية (البرازيل)', N'Português', N'🇧🇷', 0, N'european', 0, 7),
                        (N'ru-RU', 1, N'Russian', N'الروسية', N'Русский', N'🇷🇺', 0, N'slavic', 0, 8),
                        (N'zh-CHT', 1, N'Chinese Traditional', N'الصينية التقليدية', N'繁體中文', N'🇹🇼', 0, N'asian', 0, 9),
                        (N'zh-CN', 1, N'Chinese Simplified', N'الصينية المبسطة', N'简体中文', N'🇨🇳', 0, N'asian', 1, 10),
                        (N'ja-JP', 1, N'Japanese', N'اليابانية', N'日本語', N'🇯🇵', 0, N'asian', 0, 11),
                        (N'ko-KR', 1, N'Korean', N'الكورية', N'한국어', N'🇰🇷', 0, N'asian', 0, 12),
                        (N'th-TH', 1, N'Thai', N'التايلاندية', N'ไทย', N'🇹🇭', 0, N'asian', 0, 13),
                        (N'hi-IN', 1, N'Hindi', N'الهندية', N'हिन्दी', N'🇮🇳', 0, N'asian', 0, 14),
                        (N'he-IL', 1, N'Hebrew', N'العبرية', N'עברית', N'🇮🇱', 1, N'middleEast', 0, 15),
                        (N'tr-TR', 1, N'Turkish', N'التركية', N'Türkçe', N'🇹🇷', 0, N'middleEast', 0, 16),
                        (N'fa-IR', 1, N'Persian', N'الفارسية', N'فارسی', N'🇮🇷', 1, N'middleEast', 0, 17),
                        (N'ur-PK', 1, N'Urdu', N'الأردية', N'اردو', N'🇵🇰', 1, N'middleEast', 0, 18),
                        (N'sw-KE', 1, N'Swahili', N'السواحيلية', N'Kiswahili', N'🇰🇪', 0, N'african', 0, 19),
                        (N'id-ID', 1, N'Indonesian', N'الإندونيسية', N'Bahasa Indonesia', N'🇮🇩', 0, N'new', 1, 20),
                        (N'bn-BD', 1, N'Bengali', N'البنغالية', N'বাংলা', N'🇧🇩', 0, N'new', 1, 21),
                        (N'ms-MY', 1, N'Malay', N'الماليزية', N'Bahasa Melayu', N'🇲🇾', 0, N'new', 1, 22),
                        (N'pl-PL', 1, N'Polish', N'البولندية', N'Polski', N'🇵🇱', 0, N'european', 0, 23),
                        (N'nl-NL', 1, N'Dutch', N'الهولندية', N'Nederlands', N'🇳🇱', 0, N'european', 0, 24),
                        (N'sv-SE', 1, N'Swedish', N'السويدية', N'Svenska', N'🇸🇪', 0, N'european', 0, 25),
                        (N'ro-RO', 1, N'Romanian', N'الرومانية', N'Română', N'🇷🇴', 0, N'european', 0, 26),
                        (N'fi-FI', 1, N'Finnish', N'الفنلندية', N'Suomi', N'🇫🇮', 0, N'european', 0, 27),
                        (N'lv-LV', 1, N'Latvian', N'اللاتفية', N'Latviešu', N'🇱🇻', 0, N'european', 0, 28),
                        (N'lt-LT', 1, N'Lithuanian', N'الليتوانية', N'Lietuvių', N'🇱🇹', 0, N'european', 0, 29),
                        (N'et-EE', 1, N'Estonian', N'الإستونية', N'Eesti', N'🇪🇪', 0, N'european', 0, 30),
                        (N'el-GR', 1, N'Greek', N'اليونانية', N'Ελληνικά', N'🇬🇷', 0, N'european', 0, 31),
                        (N'bg-BG', 1, N'Bulgarian', N'البلغارية', N'Български', N'🇧🇬', 0, N'european', 0, 32),
                        (N'uk-UA', 1, N'Ukrainian', N'الأوكرانية', N'Українська', N'🇺🇦', 0, N'slavic', 0, 33),
                        (N'bs-Latn', 1, N'Bosnian', N'البوسنية', N'Bosanski', N'🇧🇦', 0, N'european', 0, 34),
                        (N'az-Latn-AZ', 1, N'Azerbaijani', N'الأذربيجانية', N'Azərbaycan', N'🇦🇿', 0, N'middleEast', 0, 35),
                        (N'uz-Latn-UZ', 1, N'Uzbek', N'الأوزبكية', N'Oʻzbekcha', N'🇺🇿', 0, N'asian', 0, 36),
                        (N'ka-GE', 1, N'Georgian', N'الجورجية', N'ქართული', N'🇬🇪', 0, N'middleEast', 0, 37);
                END
            ", conn);

            checkCmd.ExecuteNonQuery();
        }
    }

    private void SendJson(HttpContext context, Dictionary<string, object> data)
    {
        var serializer = new JavaScriptSerializer();
        context.Response.Write(serializer.Serialize(data));
    }

    private void SendError(HttpContext context, string message, int statusCode)
    {
        context.Response.StatusCode = statusCode;
        var error = new Dictionary<string, object>
        {
            ["success"] = false,
            ["error"] = message,
            ["timestamp"] = DateTime.UtcNow.ToString("o")
        };
        SendJson(context, error);
    }

    public bool IsReusable => false;
}
