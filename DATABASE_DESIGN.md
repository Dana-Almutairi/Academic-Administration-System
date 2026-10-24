# Academic Administration System
## Database Design

### Database Name
AcademicAdministrationDB

### Database Technology
Microsoft SQL Server

## Table 1: Students

| Column | Data Type | Constraints |
|---|---|---|
| StudentID | INT | Primary Key, Identity |
| FirstName | NVARCHAR(50) | NOT NULL |
| LastName | NVARCHAR(50) | NOT NULL |
| Email | NVARCHAR(100) | NOT NULL, UNIQUE |
| PhoneNumber | NVARCHAR(20) | NULL |

## Table 2: Faculty

| Column | Data Type | Constraints |
|---|---|---|
| FacultyID | INT | Primary Key, Identity |
| FirstName | NVARCHAR(50) | NOT NULL |
| LastName | NVARCHAR(50) | NOT NULL |
| Email | NVARCHAR(100) | NOT NULL, UNIQUE |
| Department | NVARCHAR(100) | NOT NULL |

## Database Objectives

- Centralize student records.
- Centralize faculty records.
- Reduce manual record handling.
- Improve data consistency.
- Prevent duplicate record identifiers.
- Validate required information.

## Entity Relationship Diagram (ERD)

### Students Entity

- StudentID (Primary Key)
- FirstName
- LastName
- Email (Unique)
- PhoneNumber

### Faculty Entity

- FacultyID (Primary Key)
- FirstName
- LastName
- Email (Unique)
- Department

### Relationships

The Students and Faculty entities are independent.

No direct foreign key relationship is required
for the current project scope.

### Data Integrity Rules

1. Every student must have a unique StudentID.
2. Every faculty member must have a unique FacultyID.
3. Student emails must be unique within the Students table.
4. Faculty emails must be unique within the Faculty table.
5. FirstName, LastName, and Email are required.
6. Department is required for faculty members.
7. PhoneNumber is optional for students.