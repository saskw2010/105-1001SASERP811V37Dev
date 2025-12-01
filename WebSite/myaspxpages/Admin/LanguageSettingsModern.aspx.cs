using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using eZee.Web;

public partial class myaspxpages_Admin_LanguageSettingsModern : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Page uses client-side translation via JavaScript
            // All labels are set in ASPX with default Text attributes
            Page.Title = "Language Settings";
        }
    }
}
