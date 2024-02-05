#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WWDemo.Api/WWDemo.Api.csproj", "WWDemo.Api/"]
RUN dotnet restore "./WWDemo.Api/./WWDemo.Api.csproj"
COPY . .
WORKDIR "/src/WWDemo.Api"
RUN dotnet build "./WWDemo.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./WWDemo.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WWDemo.Api.dll"]