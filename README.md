# Employee Management GraphQL

![GitHub repo size](https://img.shields.io/github/repo-size/vzapata007/EmployeeManagement_GraphQL)
![GitHub contributors](https://img.shields.io/github/contributors/vzapata007/EmployeeManagement_GraphQL)
![GitHub stars](https://img.shields.io/github/stars/vzapata007/EmployeeManagement_GraphQL?style=social)
![GitHub forks](https://img.shields.io/github/forks/vzapata007/EmployeeManagement_GraphQL?style=social)
![GitHub license](https://img.shields.io/github/license/vzapata007/EmployeeManagement_GraphQL)

This project provides a GraphQL API for managing employee data, built with .NET 8 and SQL Server.

## Overview

This GraphQL-based API allows CRUD operations on employee records, providing a flexible and efficient way to manage employee data.

## Features

- **GraphQL API:** Implements a GraphQL endpoint for querying and mutating employee data.
- **CRUD Operations:** Supports Create, Read, Update, and Delete operations for employee records.
- **Schema:** Defines a GraphQL schema outlining available queries and mutations.
- **Data Management:** Handles employee data using .NET 8 and interacts with SQL Server.
- **Authentication:** Optional feature. Implement authentication as needed.
- **Error Handling:** Includes robust error handling mechanisms.

## Technologies Used

- **.NET 8**: Core framework for building and running applications.
- **GraphQL**: Query language for APIs.
- **SQL Server**: Microsoft's relational database management system.
- **Entity Framework Core**: Object-relational mapping framework for .NET.
- **[Other relevant technologies]**: Include any additional technologies used in your project.

## Getting Started

To get a local copy up and running, follow these steps:

### Prerequisites

- .NET 8 SDK - Download and install from [Microsoft](https://dotnet.microsoft.com/download).
- SQL Server - Ensure SQL Server is installed and running.

### Installation

1. **Clone the repository:**
   ```sh
   git clone https://github.com/vzapata007/EmployeeManagement_GraphQL.git
2.	Set up your database:
o	Create a SQL Server database for the project.
o	Update connection strings in appsettings.json to point to your database.
3.	Build and run the project:
sh
Copy code
dotnet build
dotnet run
Usage
1.	Open GraphQL Playground or your preferred GraphQL client:
o	URL: http://localhost:<port>/ui/graphql
o	Explore and interact with the API endpoints.


