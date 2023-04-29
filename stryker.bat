dotnet tool restore
dotnet restore
dotnet build --no-restore
dotnet stryker -tp tests/Test.Nuget.Please.Dont.Use.Tests/Test.Nuget.Please.Dont.Use.Tests.csproj --reporter cleartext --reporter html -o