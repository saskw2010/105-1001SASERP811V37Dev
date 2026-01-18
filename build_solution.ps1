$vswhere = "C:\Program Files (x86)\Microsoft Visual Studio\Installer\vswhere.exe"
$solution = "SASERP811V37.sln"

if (Test-Path $vswhere) {
    $msbuildPath = & $vswhere -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe
    if ($msbuildPath) {
        Write-Host "Found MSBuild at: $msbuildPath"
        & $msbuildPath $solution /t:Build /p:Configuration=Debug
        exit
    }
}

# Fallback to .NET Framework MSBuild
$oldMsBuild = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"
if (Test-Path $oldMsBuild) {
    Write-Host "Using Legacy MSBuild at: $oldMsBuild"
    & $oldMsBuild $solution /t:Build /p:Configuration=Debug
} else {
    Write-Error "Could not find MSBuild."
}
