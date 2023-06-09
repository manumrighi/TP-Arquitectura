#1 Contruir la imagen de node
FROM node:16-alpine AS build

WORKDIR /usr/src/app

COPY package*.json ./

RUN npm install

COPY . .

RUN npm run build --prod

RUN ls -alt

#2 Contruir la imagen de nginx
FROM nginx:1.17.1-alpine

COPY --from=build /usr/src/app/dist/feagenda-telefonica /usr/share/nginx/html

EXPOSE 80
