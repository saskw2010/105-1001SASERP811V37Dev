$aspnetCompiler = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\aspnet_compiler.exe"
$websitePath = "E:\2021-06-HP-D-drive\2021_07_CodeOnTime\105ClassicVBREPOS\105-1001SASERP811V37\WebSite"

if (Test-Path $aspnetCompiler) {
    Write-Host "Using ASP.NET Compiler at: $aspnetCompiler"
    Write-Host "Building WebSite at: $websitePath"
    
    # -v / : Virtual path (root)
    # -p : Physical path
    & $aspnetCompiler -v / -p $websitePath
    
    if ($LASTEXITCODE -eq 0) {
        Write-Host "Build SUCCESS!" -ForegroundColor Green
    } else {
        Write-Host "Build FAILED!" -ForegroundColor Red
    }
} else {
    Write-Error "Could not find aspnet_compiler.exe"
}
