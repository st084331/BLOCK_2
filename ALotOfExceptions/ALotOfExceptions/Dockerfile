FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ALotOfExceptions/ALotOfExceptions.csproj", "ALotOfExceptions/"]
RUN dotnet restore "ALotOfExceptions/ALotOfExceptions.csproj"
COPY . .
WORKDIR "/src/ALotOfExceptions"
RUN dotnet build "ALotOfExceptions.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ALotOfExceptions.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ALotOfExceptions.dll"]
