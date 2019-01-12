# Paths
$slnPath = (Get-Item -Path "./" -Verbose).FullName
$nupkgPath = Join-Path $slnPath "nupkg"
$srcPath = Join-Path $slnPath "src"

# List of projects
$projects = (
    "Essensoft.AspNetCore.Payment.Alipay",
    "Essensoft.AspNetCore.Payment.JDPay",
    "Essensoft.AspNetCore.Payment.LianLianPay",
    "Essensoft.AspNetCore.Payment.QPay",
    "Essensoft.AspNetCore.Payment.Security",
    "Essensoft.AspNetCore.Payment.UnionPay",
    "Essensoft.AspNetCore.Payment.WeChatPay"
)

# Rebuild solution
Set-Location $slnPath
& dotnet restore

# Copy all nuget packages to the pack folder
foreach($project in $projects) {
    
    $projectFolder = Join-Path $srcPath $project

    # Create nuget package
    Set-Location $projectFolder
    Remove-Item -Recurse (Join-Path $projectFolder "bin/Release")
    & dotnet msbuild /p:Configuration=Release
    & dotnet msbuild /t:pack /p:Configuration=Release

    # Copy nuget package
    $projectPackPath = Join-Path $projectFolder ("/bin/Release/" + $project + ".*.nupkg")
    Move-Item $projectPackPath $nupkgPath
}

# Go back to the nupkg folder
Set-Location $nupkgPath

# Push nuget package 
dotnet nuget push *.nupkg -s https://api.nuget.org/v3/index.json