FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CarMarketBackend/CarMarketBackend.csproj", "CarMarketBackend/"]
RUN dotnet restore "CarMarketBackend/CarMarketBackend.csproj"
COPY . .
WORKDIR "/src/CarMarketBackend"
RUN dotnet build "CarMarketBackend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarMarketBackend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarMarketBackend.dll"]
