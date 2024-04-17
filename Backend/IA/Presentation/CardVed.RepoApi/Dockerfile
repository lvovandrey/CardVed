#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["IA/Presentation/CardVed.RepoApi/CardVed.RepoApi.csproj", "IA/Presentation/CardVed.RepoApi/"]
RUN dotnet restore "IA/Presentation/CardVed.RepoApi/CardVed.RepoApi.csproj"
COPY . .
WORKDIR "/src/IA/Presentation/CardVed.RepoApi"
RUN dotnet build "CardVed.RepoApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CardVed.RepoApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CardVed.RepoApi.dll"]