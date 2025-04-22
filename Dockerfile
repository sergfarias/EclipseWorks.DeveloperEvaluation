#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/EclipseWorks.DeveloperEvaluation.WebApi/EclipseWorks.DeveloperEvaluation.WebApi.csproj", "src/EclipseWorks.DeveloperEvaluation.WebApi/"]
COPY ["src/EclipseWorks.DeveloperEvaluation.IoC/EclipseWorks.DeveloperEvaluation.IoC.csproj", "src/EclipseWorks.DeveloperEvaluation.IoC/"]
COPY ["src/EclipseWorks.DeveloperEvaluation.Domain/EclipseWorks.DeveloperEvaluation.Domain.csproj", "src/EclipseWorks.DeveloperEvaluation.Domain/"]
COPY ["src/EclipseWorks.DeveloperEvaluation.Common/EclipseWorks.DeveloperEvaluation.Common.csproj", "src/EclipseWorks.DeveloperEvaluation.Common/"]
COPY ["src/EclipseWorks.DeveloperEvaluation.Application/EclipseWorks.DeveloperEvaluation.Application.csproj", "src/EclipseWorks.DeveloperEvaluation.Application/"]
COPY ["src/EclipseWorks.DeveloperEvaluation.ORM/EclipseWorks.DeveloperEvaluation.ORM.csproj", "src/EclipseWorks.DeveloperEvaluation.ORM/"]
RUN dotnet restore "./src/EclipseWorks.DeveloperEvaluation.WebApi/EclipseWorks.DeveloperEvaluation.WebApi.csproj"
COPY . .
WORKDIR "/src/src/EclipseWorks.DeveloperEvaluation.WebApi"
RUN dotnet build "./EclipseWorks.DeveloperEvaluation.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./EclipseWorks.DeveloperEvaluation.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EclipseWorks.DeveloperEvaluation.WebApi.dll"]