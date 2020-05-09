#Based on https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/docker/building-net-docker-images?view=aspnetcore-3.1
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

# copy everything
COPY source/ ./
RUN dotnet restore {{namespace}}.sln

# build app
RUN dotnet publish {{namespace}}.Api -c Release

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build /app/{{namespace}}.Api/bin/Release/netcoreapp3.1/publish ./
ENTRYPOINT ["dotnet", "{{namespace}}.Api.dll"]