# 1. Construir la imagen de node
FROM node:16-alpine AS build
# Establece la imagen base como Node.js 16 en Alpine para construir la aplicación.

WORKDIR /usr/src/app
# Establece el directorio de trabajo dentro del contenedor como "/usr/src/app".

COPY package*.json ./
# Copia los archivos package.json y package-lock.json al directorio de trabajo.

RUN npm install
# Ejecuta el comando "npm install" para instalar las dependencias del proyecto.

COPY . .
# Copia todos los archivos y carpetas del directorio actual al directorio de trabajo.

RUN npm run build --prod
# Ejecuta el comando "npm run build --prod" para construir la aplicación en modo de producción.

RUN ls -alt
# Muestra el contenido del directorio actual en la salida del contenedor.

# 2. Construir la imagen de nginx
FROM nginx:1.17.1-alpine
# Establece la imagen base como Nginx 1.17.1 en Alpine para servir la aplicación.

COPY --from=build /usr/src/app/dist/feagenda-telefonica /usr/share/nginx/html
# Copia los archivos generados en la etapa anterior al directorio de trabajo de Nginx.

EXPOSE 80
# Expone el puerto 80 para que el tráfico pueda acceder a la aplicación.


