del "*.nupkg"
"..\..\oqtane.framework\oqtane.package\nuget.exe" pack RLTechnologies.Theme.HealthCare.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework\Oqtane.Server\wwwroot\Packages\" /Y
