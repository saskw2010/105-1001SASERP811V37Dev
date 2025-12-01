# Simple SASERP Launcher
# Handles temp files from both C: and E: drives

param([int]$Port = 8080)

Write-Host "=== SASERP V37 Simple Launcher ===" -ForegroundColor Green
Write-Host "Port: $Port" -ForegroundColor Yellow

# Stop any existing IIS Express processes
Write-Host "Stopping existing IIS Express processes..." -ForegroundColor Cyan
Get-Process -Name "iisexpress" -ErrorAction SilentlyContinue | Stop-Process -Force -ErrorAction SilentlyContinue

# Clean temp files from multiple locations
Write-Host "Cleaning temporary files..." -ForegroundColor Cyan
$tempPaths = @(
    "$env:LOCALAPPDATA\Temp\iisexpress",
    "$env:TEMP\Temporary ASP.NET Files",
    "C:\Users\$env:USERNAME\AppData\Local\Temp\iisexpress",
    "E:\AppData\Local\Temp\iisexpress",
    "E:\Users\$env:USERNAME\AppData\Local\Temp\iisexpress"
)

foreach ($tempPath in $tempPaths) {
    if (Test-Path $tempPath) {
        try {
            Remove-Item "$tempPath\*" -Recurse -Force -ErrorAction SilentlyContinue
            Write-Host "Cleaned: $tempPath" -ForegroundColor Green
        } catch {
            Write-Host "Could not clean: $tempPath" -ForegroundColor Yellow
        }
    }
}

# Find IIS Express
$iisExpress = "C:\Program Files\IIS Express\iisexpress.exe"
if (!(Test-Path $iisExpress)) {
    $iisExpress = "C:\Program Files (x86)\IIS Express\iisexpress.exe"
}

if (!(Test-Path $iisExpress)) {
    Write-Host "ERROR: IIS Express not found" -ForegroundColor Red
    exit 1
}

$sitePath = "E:\2021-06-HP-D-drive\2021_07_CodeOnTime\105ClassicVBREPOS\105-1001SASERP811V37\WebSite"
$configPath = Join-Path $sitePath "applicationhost.config"

Write-Host "Site Path: $sitePath" -ForegroundColor Yellow
Write-Host "Config: $configPath" -ForegroundColor Yellow
Write-Host "URL: http://localhost:$Port" -ForegroundColor Cyan
Write-Host ""
Write-Host "Starting IIS Express..." -ForegroundColor Green
Write-Host "Press Ctrl+C to stop" -ForegroundColor Yellow

try {
    if (Test-Path $configPath) {
        Write-Host "Using local applicationhost.config" -ForegroundColor Green
        & $iisExpress /config:"$configPath" /systray:false
    } else {
        Write-Host "Using default configuration" -ForegroundColor Yellow
        & $iisExpress /path:"$sitePath" /port:$Port /clr:v4.0 /systray:false
    }
} catch {
    Write-Host "ERROR: $($_.Exception.Message)" -ForegroundColor Red
}

Write-Host ""
Write-Host "SASERP server stopped." -ForegroundColor Yellow
