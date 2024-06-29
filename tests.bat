dotnet restore
dotnet build -c Release --no-restore --no-incremental
dotnet test -c Release --no-build --verbosity normal --results-directory ./TestResults
