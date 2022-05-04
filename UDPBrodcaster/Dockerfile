FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["UDPBrodcaster/UDPBrodcaster.csproj", "UDPBrodcaster/"]
RUN dotnet restore "UDPBrodcaster/UDPBrodcaster.csproj"
COPY . .
WORKDIR "/src/UDPBrodcaster"
RUN dotnet build "UDPBrodcaster.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UDPBrodcaster.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UDPBrodcaster.dll"]
