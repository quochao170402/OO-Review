FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OO-Review/OO-Review.csproj", "OO-Review/"]
RUN dotnet restore "OO-Review/OO-Review.csproj"
COPY . .
WORKDIR "/src/OO-Review"
RUN dotnet build "OO-Review.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OO-Review.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OO-Review.dll"]
