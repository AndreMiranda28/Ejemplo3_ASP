#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Ejemplo3_ASP/Ejemplo3_ASP.csproj", "Ejemplo3_ASP/"]
RUN dotnet restore "Ejemplo3_ASP/Ejemplo3_ASP.csproj"
COPY . .
WORKDIR "/src/Ejemplo3_ASP"
RUN dotnet build "Ejemplo3_ASP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ejemplo3_ASP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ejemplo3_ASP.dll"]

#FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build-step
#WORKDIR /build
#COPY . .
#RUN dotnet restore
#RUN dotnet publish -c Release -o /app
#
## Build runtime image
#FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine
#
#WORKDIR /app
#COPY --from=build-step /app .
#ENTRYPOINT ["dotnet", "Almacen.WebApi.dll"]
#
#EXPOSE 80
#EXPOSE 443
#