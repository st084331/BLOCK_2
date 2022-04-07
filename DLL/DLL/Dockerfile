FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DLL/DLL.csproj", "DLL/"]
RUN dotnet restore "DLL/DLL.csproj"
COPY . .
WORKDIR "/src/DLL"
RUN dotnet build "DLL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DLL.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DLL.dll"]
