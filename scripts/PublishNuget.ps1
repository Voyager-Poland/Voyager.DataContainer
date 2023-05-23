$version='1.0.0'
dotnet build -c Release   /property:Version=$version
dotnet pack -c Release /property:Version=$version

$ostatniPakiet = (gci .\src\Voyager.DataContainer\bin\Release\*.nupkg | select -last 1).Name
$sciezka = ".\src\Voyager.DataContainer\bin\Release\$ostatniPakiet"

dotnet nuget push "$sciezka" -s Voyager-Poland
