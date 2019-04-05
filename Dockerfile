FROM mcr.microsoft.com/dotnet/core/sdk AS build
WORKDIR /app
COPY . .
ENV ASPNETCORE_URLS http://*:5000
ENV ASPNETCORE_ENVIRONMENT docker
ENTRYPOINT dotnet run --project src/DShop.Blazor