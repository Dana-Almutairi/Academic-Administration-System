# Academic Administration System

A web-based academic administration system developed using ASP.NET Core MVC, C#, Entity Framework Core, and SQL Server.

## Overview

The Academic Administration System is designed to centralize student and faculty record management through a simple and organized web interface.

The system provides CRUD operations, input validation, and database-level email uniqueness constraints to support accurate and consistent academic records.

## Technologies Used

- C#
- ASP.NET Core MVC (.NET 10)
- Entity Framework Core
- SQL Server
- HTML
- CSS
- Bootstrap

## Features

### Student Management
- Add new students.
- View student records.
- Update student information.
- Delete student records.
- Validate required fields and email formats.
- Prevent duplicate student email addresses.

### Faculty Management
- Add new faculty members.
- View faculty records.
- Update faculty information.
- Delete faculty records.
- Validate required fields and email formats.
- Prevent duplicate faculty email addresses.

### Centralized Dashboard
- Access student and faculty management sections.
- Navigate between administrative functions.

### Data Validation
- Required field validation.
- Email format validation.
- Maximum field length restrictions.
- Unique email constraints in the database.

## Project Structure

- `Controllers/` - Handles application requests and CRUD operations.
- `Models/` - Defines student and faculty entities.
- `Views/` - Contains the user interface.
- `Data/` - Contains the Entity Framework Core database context.
- `Migrations/` - Contains database migration files.

## Getting Started

### Prerequisites

- .NET 10 SDK
- SQL Server
- Visual Studio or Visual Studio Code

### Installation

1. Clone the repository.
2. Open the project directory.
3. Configure the SQL Server connection string in `appsettings.json`.
4. Restore the project dependencies:

```bash
dotnet restore
```

5. Apply the database migrations:

```bash
dotnet ef database update
```

6. Run the application:

```bash
dotnet run
```

7. Open the localhost URL displayed in the terminal.

## Testing

The following functionality has been manually tested:

- Student CRUD operations.
- Faculty CRUD operations.
- Dashboard navigation.
- Required field validation.
- Email format validation.
- Duplicate email prevention.
- Database connectivity.
- Application build.

## Security Notes

This project is intended for local demonstration and portfolio purposes.

Authentication and authorization are not implemented. The application should not be deployed publicly without appropriate access controls and additional security review.

## Author

**Dana Almutairi**

Software Engineering Graduate

## License

No open-source license has been assigned to this repository.