#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WebShop.Api/WebShop.Api.csproj", "WebShop.Api/"]
RUN dotnet restore "./WebShop.Api/./WebShop.Api.csproj"
COPY . .
WORKDIR "/src/WebShop.Api"
RUN dotnet build "./WebShop.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./WebShop.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebShop.Api.dll"]