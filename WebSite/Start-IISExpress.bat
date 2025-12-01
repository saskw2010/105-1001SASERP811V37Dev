@echo off
REM IIS Express Launcher for SASERP811V37
REM Run this batch file to start the application with IIS Express

echo.
echo 🚀 Starting SASERP811V37 with IIS Express...
echo.

REM Set variables
set SITE_PATH=E:\2021-06-HP-D-drive\2021_07_CodeOnTime\105ClassicVBREPOS\105-1001SASERP811V37\WebSite
set PORT=8080
set CONFIG_FILE=%SITE_PATH%\applicationhost.config

REM Check if .NET Framework 4.8 is available
echo ✅ Checking .NET Framework...
reg query "HKLM\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" /v Release >nul 2>&1
if %errorlevel% equ 0 (
    echo ✅ .NET Framework 4.x is installed
) else (
    echo ❌ .NET Framework 4.x not found
    pause
    exit /b 1
)

REM Check if site path exists
if not exist "%SITE_PATH%" (
    echo ❌ Site path not found: %SITE_PATH%
    pause
    exit /b 1
)

echo ✅ Site path verified: %SITE_PATH%

REM Launch IIS Express
echo.
echo 🌐 Starting IIS Express on port %PORT%...
echo 📂 Physical Path: %SITE_PATH%
echo 📄 Config File: %CONFIG_FILE%
echo.
echo 🔗 Application will be available at: http://localhost:%PORT%
echo.

REM Start IIS Express
"C:\Program Files\IIS Express\iisexpress.exe" /path:"%SITE_PATH%" /port:%PORT% /clr:v4.0

REM If the above fails, try with config file
if %errorlevel% neq 0 (
    echo.
    echo 🔄 Trying with custom config file...
    "C:\Program Files\IIS Express\iisexpress.exe" /config:"%CONFIG_FILE%" /site:"SASERP811V37"
)

echo.
echo 🛑 IIS Express stopped.
pause
