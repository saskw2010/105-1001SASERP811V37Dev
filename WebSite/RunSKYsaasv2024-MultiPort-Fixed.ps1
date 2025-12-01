# Enhanced SASERP Launcher - Multi-Port Support
# Allows running multiple sites on different ports simultaneously

param(
    [int]$Port = 8080,
    [string]$SiteName = "SKYsaas",
    [switch]$StopAll,
    [switch]$ShowRunning
)

Write-Host "=== skysaas v2024 Multi-Port Launcher ===" -ForegroundColor Green
Write-Host "Port: $Port | Site: $SiteName" -ForegroundColor Yellow

# Show running processes if requested
if ($ShowRunning) {
    Write-Host "`n=== Currently Running IIS Express Processes ===" -ForegroundColor Cyan
    $processes = Get-Process -Name "iisexpress" -ErrorAction SilentlyContinue
    if ($processes) {
        foreach ($proc in $processes) {
            $commandLine = (Get-WmiObject Win32_Process -Filter "ProcessId = $($proc.Id)").CommandLine
            Write-Host "PID: $($proc.Id) | Command: $commandLine" -ForegroundColor Green
        }
    } else {
        Write-Host "No IIS Express processes running" -ForegroundColor Yellow
    }
    Write-Host ""
}

# Stop all IIS Express if requested
if ($StopAll) {
    Write-Host "Stopping ALL IIS Express processes..." -ForegroundColor Red
    Get-Process -Name "iisexpress" -ErrorAction SilentlyContinue | Stop-Process -Force -ErrorAction SilentlyContinue
    Write-Host "All IIS Express processes stopped." -ForegroundColor Green
    return
}

# Check if port is already in use
$portInUse = Get-NetTCPConnection -LocalPort $Port -ErrorAction SilentlyContinue
if ($portInUse) {
    Write-Host "WARNING: Port $Port is already in use!" -ForegroundColor Red
    Write-Host "Processes using port ${Port}:" -ForegroundColor Yellow
    
    $processes = Get-Process -Name "iisexpress" -ErrorAction SilentlyContinue
    foreach ($proc in $processes) {
        $commandLine = (Get-WmiObject Win32_Process -Filter "ProcessId = $($proc.Id)").CommandLine
        if ($commandLine -like "*:$Port*") {
            Write-Host "  PID: $($proc.Id) | $commandLine" -ForegroundColor Cyan
        }
    }
    
    $response = Read-Host "Do you want to stop the process using port ${Port}? (y/N)"
    if ($response -eq 'y' -or $response -eq 'Y') {
        # Stop only processes using this specific port
        foreach ($proc in $processes) {
            $commandLine = (Get-WmiObject Win32_Process -Filter "ProcessId = $($proc.Id)").CommandLine
            if ($commandLine -like "*:$Port*") {
                Write-Host "Stopping process PID: $($proc.Id)" -ForegroundColor Yellow
                Stop-Process -Id $proc.Id -Force -ErrorAction SilentlyContinue
            }
        }
    } else {
        Write-Host "Exiting... Please choose a different port or stop the existing process." -ForegroundColor Red
        return
    }
}

# Clean temp files only for current session
Write-Host "Cleaning temporary files for port ${Port}..." -ForegroundColor Cyan
$tempPaths = @(
    "$env:LOCALAPPDATA\Temp\iisexpress\$Port",
    "$env:TEMP\Temporary ASP.NET Files",
    "C:\Users\$env:USERNAME\AppData\Local\Temp\iisexpress",
    "E:\AppData\Local\Temp\iisexpress"
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

Write-Host "`n=== Starting $SiteName on Port $Port ===" -ForegroundColor Green
Write-Host "Site Path: $sitePath" -ForegroundColor Yellow
Write-Host "Config: $configPath" -ForegroundColor Yellow
Write-Host "URL: http://localhost:$Port" -ForegroundColor Cyan
Write-Host ""
Write-Host "Starting IIS Express for $SiteName..." -ForegroundColor Green
Write-Host "Press Ctrl+C to stop this site only" -ForegroundColor Yellow
Write-Host "Other sites on different ports will continue running" -ForegroundColor Cyan
Write-Host ""

try {
    if (Test-Path $configPath) {
        Write-Host "Using local applicationhost.config" -ForegroundColor Green
        & $iisExpress /config:"$configPath" /port:$Port /systray:false
    } else {
        Write-Host "Using default configuration" -ForegroundColor Yellow
        & $iisExpress /path:"$sitePath" /port:$Port /clr:v4.0 /systray:false
    }
} catch {
    Write-Host "ERROR: $($_.Exception.Message)" -ForegroundColor Red
}

Write-Host ""
Write-Host "Server $SiteName on port $Port stopped." -ForegroundColor Yellow
Write-Host "Other sites may still be running on different ports." -ForegroundColor Cyan
