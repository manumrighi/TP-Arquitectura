<h3>This repository contains an Angular app and a .NET app. Following are the steps required to set up and run the applications, as well as instructions for using Docker and the docker-compose.yml file.</h3>

<h3> Previous requirements:</h3>

    Make sure you have the following software versions installed on your system:

        Angular:(https://angular.io/guide/setup-local)
        .NET: (https://docs.microsoft.com/es-es/dotnet/core/install/windows)
        Docker: (https://docs.docker.com/docker-for-windows/install/)

<h3>Configuration and execution of applications:</h3>

     1- Clone this repository on your local machine:
         git clone https://github.com/manumrighi/TP-Arquitectura

     2- Configuration of the Angular application:
         cd TP-Arquitectura/AgendaContacts-FRONT
         npm install

         This install the project dependencies

     3- Compilation and execution of the Angular application:
         ng serve # Compile and run the application in development mode
         The app will be available at http://localhost:4200

     4- Configuration of the .NET application:
         cd TP-Arquitectura/AgendaContactos-BACK/ApiAgendaTupBrande
         dotnet restore

         Restores the project packages
         The app will be available at http://localhost:5010

<h3>Using the docker-compose.yml file local.</h3>

     1- Make sure you have Docker installed and running on your system.

     2- In the "TP-Arquitectura" folder, execute the following command to build the Docker images:
         docker-compose up -d

        This will create and run the Docker containers according to the specifications in the docker-compose.yml file

     3-Once the containers are up and running, the Angular app will be available at http://localhost:4200 and the .NET app will be available at http://localhost:5010/swagger/index.html

<h3>Using the docker-compose.yml file remote.</h3>

    1- Make sure you have Docker installed and running on your system.

    2-In the "images" folder, execute the following command to build the Docker images:
         docker-compose up -d
    
        This will create and run the Docker containers according to the specifications in the docker-compose.yml file
        You can use this option if you do not want to download the repository locally, what docker-compose will do is automatically download the images directly from https://hub.docker.com
    
    3-Once the containers are up and running, the Angular app will be available at http://localhost:4200 and the .NET app will be available at http://localhost:5010/swagger/index.html

<h3>Remember that you must have sufficient permissions to run the commands and make sure you have the correct versions of Angular, .NET and Docker installed on your system.</h3>

<h3>Members: Rodriguez Geronimo, Valenti Dino, Morichi Righi Manuel, Ricci Ramos Valentino.</h3>
