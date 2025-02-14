# Use .NET 9 SDK for building
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS sdk
WORKDIR /app

COPY ./ ./
RUN dotnet publish -c Release -o out

# Use .NET 9 runtime for running the app
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=sdk /app/out .
ENTRYPOINT ["dotnet", "MinimalApi.dll"]
