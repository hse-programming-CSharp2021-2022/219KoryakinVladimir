FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Task6/Task6.csproj", "Task6/"]
RUN dotnet restore "Task6/Task6.csproj"
COPY . .
WORKDIR "/src/Task6"
RUN dotnet build "Task6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task6.dll"]
