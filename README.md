# Learn Build Game Store with .NET REST APIs

This project is learning .NET REST APIs. 

## Table of Contents

1. [Installation](#installation)
2. [About Repositor](#repository)
3. [Service Lifetime](#service-lifetime)

## Installation

Provide instructions on how to install the project. Include any dependencies that need to be installed and how to install them.

```bash
# Example installation instructions
dotnet run
dotnet build
```

## Repository
## Service-Lifetime
1. Transient
2. Scope
3. Singleton

## Dependency-Injection
<IGamesRepository, InMemGamesRepository>: Ini adalah informasi yang menyatakan bahwa layanan yang didaftarkan (yang akan diinjeksikan ke dalam kelas lain dalam aplikasi) adalah sebuah implementasi dari antarmuka IGamesRepository, dan implementasinya disediakan oleh kelas InMemGamesRepository.

## Data Transfer Object
DTO int the context of a REST API, a DTO can be considered a contract between the client and server that defines the expectation and requirements. 

## Install Docker
1. https://docs.docker.com/desktop/install/linux-install/
2. https://hub.docker.com/_/microsoft-mssql-server


```powerShell 
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=P@ssword123" -p 1433:1433 -v sqlvolume:/var/opt/mssql -d --rm --name mssql mcr.microsoft.com/mssql/server:2022-latest
```

## Setting the connection string to secret manager

```powerShell
dotnet user-secrets init
$sa_password = "[SA PASSWORD HERE]"
dotnet user-secrets set "ConnectionStrings:GameStoreContext" "Server=localhost; Database=GameStore; User Id=sa; Password=$sa_password;TrustServerCertificate=True"
```

