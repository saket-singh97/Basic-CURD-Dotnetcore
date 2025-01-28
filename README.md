# DOTNET Core CRUD API - Dockerized with SQL Server

This is a simple **CRUD API** built using **.NET Core** and **SQL Server**. It is **Dockerized** for easy deployment and management, allowing seamless creation, reading, updating, and deletion of employee records.

## Features

- **Create**: Add new employee records to the database.
- **Read**: Retrieve all or specific employee records.
- **Dockerized**: Both the API and SQL Server are containerized using Docker for simplified setup and deployment.

## Prerequisites

- **Docker** (for running containers)
- **.NET Core SDK 8.0 or higher**
- **SQL Server** (Dockerized in this project)

## Setup and Installation

### 1. Clone the repository

Clone the project to your local machine using the following command:

git clone https://github.com/saket-singh97/DOTNET-Core-CRUD-API-Dockerized-with-SQL-Server.git
cd DOTNET-Core-CRUD-API-Dockerized-with-SQL-Server


### 2.Build Docker Containers
Run the following command to build and start the containers:

docker-compose up --build


### 3.Access the API
Once the containers are up and running, you can access the API at:
http://localhost:8001/api/employee
You can also access the Swagger UI at:
http://localhost:8001/swagger


### 4.Database Initialization
The project uses a DataAccessLayer to interact with the SQL Server database. The database is created automatically, and sample employee data is seeded during the container startup.

### 5. Check API Endpoints
GET /api/employee/Fetch: Fetch all employee records.
POST /api/employee/Create: Create a new employee record.


### Dockerization

This project is Dockerized, meaning you can run it in any Docker-supported environment without needing to install .NET or SQL Server locally. The Dockerfile and docker-compose.yml are configured to build the application and database containers.

Docker Commands

To build and run the containers:
docker-compose up --build

To stop the containers:
docker-compose down


### Contributing
Feel free to fork the repository and contribute. Submit pull requests for bug fixes or new features.

