#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WWDemo.MigrationRunner/WWDemo.MigrationRunner.csproj", "WWDemo.MigrationRunner/"]
COPY ["WWDemo.Data/WWDemo.Data.csproj", "WWDemo.Data/"]
COPY ["WWDemo.Models/WWDemo.Models.csproj", "WWDemo.Models/"]
RUN dotnet restore "./WWDemo.MigrationRunner/./WWDemo.MigrationRunner.csproj"
COPY . .
WORKDIR "/src/WWDemo.MigrationRunner"
RUN dotnet build "./WWDemo.MigrationRunner.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WWDemo.MigrationRunner.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WWDemo.MigrationRunner.dll"]