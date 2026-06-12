# Student Database Application

This is a backend console application built using C# and the .NET Framework that demonstrates database management using Entity Framework (EF) Code-First development.

## Description

The application highlights how to build a database structure directly from C# object models without writing any raw SQL commands. By implementing a custom database context (`DbContext`), the application automatically handles database generation, mapping, and schema updates. 

Upon execution, the application initializes the database context, establishes a connection to a local server instance, and programmatically inserts a new student record to verify data persistence.

## Core Features & Technical Skills

* **Code-First Workflow:** Designed the database schema entirely using structured C# classes (`Student` entity).
* **Entity Framework Integration:** Utilized NuGet Package Manager to implement `EntityFramework` and manage data access layers.
* **Data Context Management:** Inherited from `DbContext` to create a `SchoolContext` bridge for tracking, querying, and updating entities.
* **CRUD Operations:** Implemented basic database insertion (`DbSet.Add()`) and state persistence (`SaveChanges()`) wrapped inside a resource-safe `using` statement block.

## Tech Stack

* **Language:** C#
* **Framework:** .NET Framework / .NET Console Core
* **ORM:** Entity Framework (EF6)
