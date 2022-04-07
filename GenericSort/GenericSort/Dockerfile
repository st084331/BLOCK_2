FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GenericSort/GenericSort.csproj", "GenericSort/"]
RUN dotnet restore "GenericSort/GenericSort.csproj"
COPY . .
WORKDIR "/src/GenericSort"
RUN dotnet build "GenericSort.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GenericSort.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GenericSort.dll"]
