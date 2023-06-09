FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# Establece la imagen base como el SDK de .NET 6.0 para compilar la aplicación.

WORKDIR /src
# Establece el directorio de trabajo dentro del contenedor como "/src".

COPY . .
# Copia todos los archivos y carpetas del directorio actual al directorio de trabajo.

RUN dotnet publish "ApiAgendaTupBrande.csproj" -c Release -o /app
# Compila y publica el proyecto "ApiAgendaTupBrande.csproj" en modo Release, guardando los archivos generados en el directorio "/app".

FROM mcr.microsoft.com/dotnet/aspnet:6.0
# Establece una nueva imagen base para la etapa de ejecución como ASP.NET 6.0.

WORKDIR /app
# Establece el directorio de trabajo dentro del contenedor como "/app".

COPY --from=build /app .
# Copia los archivos generados en la etapa anterior al directorio de trabajo.

ENTRYPOINT ["dotnet", "ApiAgendaTupBrande.dll"]
# Establece el punto de entrada para el contenedor, ejecutando el comando "dotnet ApiAgendaTupBrande.dll".

