
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
COPY . ./
EXPOSE 80
ENTRYPOINT ["dotnet", "GameServer01.WebAPI.dll"]