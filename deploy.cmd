SET Version=0.1.1

nuget\nuget.exe pack src\Tp.I18n.Interfaces\Tp.I18n.Interfaces.csproj -Build -Symbols -Properties Configuration=Release -Version %VERSION%
nuget\nuget.exe push Tp.I18n.Interfaces.%VERSION%.nupkg
