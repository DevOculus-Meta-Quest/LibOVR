dotnet pack LibOVR\LibOVR.csproj /p:Configuration=Release -o LibOVR\bin\Release

"C:\Program Files (x86)\nuget\nuget.exe" delete nkast.libovr 1.0.0 -Source "C:\Users\usename\.nuget\localPackages" -NonInteractive

"C:\Program Files (x86)\nuget\nuget.exe" add LibOVR\bin\Release\nkast.LibOVR.1.0.0.nupkg -Source "C:\Users\usename\.nuget\localPackages"


pause