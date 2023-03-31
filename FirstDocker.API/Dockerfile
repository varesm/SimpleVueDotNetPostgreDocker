FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FirstDocker.API/FirstDocker.API.csproj", "FirstDocker.API/"]
RUN dotnet restore "FirstDocker.API/FirstDocker.API.csproj"
COPY . .
WORKDIR "/src/FirstDocker.API"
RUN dotnet build "FirstDocker.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FirstDocker.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FirstDocker.API.dll"]
