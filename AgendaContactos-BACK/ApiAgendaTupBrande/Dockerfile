FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src

COPY . .

RUN dotnet publish "ApiAgendaTupBrande.csproj" -c Release -o /app

# Crear una imagen de runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# Establecer el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copiar la salida de la compilación
COPY --from=build /app .

ENTRYPOINT ["dotnet", "ApiAgendaTupBrande.dll"]