#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Api/LAtelier.CutestCatApi.Api.csproj", "src/Api/"]
COPY ["src/Domain/LAtelier.CutestCatApi.Domain.csproj", "src/Domain/"]
COPY ["src/Infrastructure/LAtelier.CutestCatApi.Infrastructure.csproj", "src/Infrastructure/"]
RUN dotnet restore "src/Api/LAtelier.CutestCatApi.Api.csproj"
COPY . .
WORKDIR "/src/src/Api"
RUN dotnet build "LAtelier.CutestCatApi.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LAtelier.CutestCatApi.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LAtelier.CutestCatApi.Api.dll"]