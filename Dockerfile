# https://hub.docker.com/_/microsoft-dotnet-core
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /

# copy csproj and restore as distinct layers
COPY *.csproj ./
COPY . ./
RUN dotnet restore

# copy everything else and build app
WORKDIR /
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "NullJsonTest.dll"]