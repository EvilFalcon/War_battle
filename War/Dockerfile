FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["War/War.csproj", "War/"]
RUN dotnet restore "War/War.csproj"
COPY . .
WORKDIR "/src/War"
RUN dotnet build "War.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "War.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "War.dll"]
