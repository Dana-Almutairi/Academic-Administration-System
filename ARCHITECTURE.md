# Academic Administration System
## System Architecture

### Architectural Pattern
ASP.NET Core MVC

### Main Components

1. Models
   - Student
   - Faculty

2. Views
   - Home
   - Students
   - Faculty

3. Controllers
   - HomeController
   - StudentsController
   - FacultyController

4. Data Access
   - Entity Framework Core
   - ApplicationDbContext

5. Database
   - Microsoft SQL Server

### System Workflow

User
  |
  v
View
  |
  v
Controller
  |
  v
Model / Data Access
  |
  v
SQL Server Database

## Project Structure

The application follows the MVC architectural pattern.

### Controllers
Handle user requests and application operations.

### Models
Represent student and faculty records.

### Views
Display the user interface.

### Data
Manage database access using Entity Framework Core.

### wwwroot
Contains static files such as CSS and JavaScript.

## Data Flow

### Student Management

1. The administrator opens the student management page.
2. The administrator enters or updates student information.
3. The StudentsController receives the request.
4. The system validates the submitted data.
5. Entity Framework Core performs the database operation.
6. SQL Server stores or retrieves the student record.
7. The system displays the operation result.

### Faculty Management

1. The administrator opens the faculty management page.
2. The administrator enters or updates faculty information.
3. The FacultyController receives the request.
4. The system validates the submitted data.
5. Entity Framework Core performs the database operation.
6. SQL Server stores or retrieves the faculty record.
7. The system displays the operation result.