FROM mcr.microsoft.com/dotnet/aspnet:8.0-jammy-amd64 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/BeautyInBloom.API/BeautyInBloom.API.csproj", "BeautyInBloom.API/"]
COPY ["src/BeautyInBloom.Models/BeautyInBloom.Models.csproj", "BeautyInBloom.Models/"]
RUN dotnet restore "BeautyInBloom.API/BeautyInBloom.API.csproj"
COPY . .
WORKDIR "/src/src/BeautyInBloom.API"
RUN dotnet build "BeautyInBloom.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BeautyInBloom.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BeautyInBloom.API.dll"]