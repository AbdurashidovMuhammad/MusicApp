# MusicApp - N-Tier Architecture Example

A music application built using ASP.NET Core following N-tier architecture principles. This project demonstrates clean architecture patterns, separation of concerns, and modern development practices.

## Project Structure

```
src/
├── MusicApp/           # API Layer - Web API endpoints and configuration
├── N-Tier.Application/ # Application Layer - Business logic and DTOs
├── N-Tier.Core/        # Core Layer - Domain entities and interfaces
├── N-Tier.DataAccess/  # Data Access Layer - Database operations
tests/
└── N-Tier.Shared/      # Shared testing utilities and helpers
```

## Technology Stack

- **.NET 7.0**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **AutoMapper** - Object-to-object mapping
- **FluentValidation** - Request validation
- **Swagger/OpenAPI** - API documentation
- **xUnit** - Testing framework
- **PostgreSQL** - Database

## Architecture Overview

The solution follows the N-tier architectural pattern with clear separation of concerns:

1. **API Layer (MusicApp)**
   - REST API endpoints
   - Controllers
   - Middleware configuration
   - Dependency injection setup
   - API documentation

2. **Application Layer (N-Tier.Application)**
   - Business logic
   - DTOs (Data Transfer Objects)
   - Service interfaces and implementations
   - Validation rules
   - AutoMapper profiles

3. **Core Layer (N-Tier.Core)**
   - Domain entities
   - Repository interfaces
   - Domain-specific interfaces
   - Custom exceptions
   - Constants and enums

4. **Data Access Layer (N-Tier.DataAccess)**
   - Entity Framework configurations
   - Repository implementations
   - Database context
   - Migrations
   - Data seeding

5. **Shared Testing (N-Tier.Shared)**
   - Testing utilities
   - Mock data helpers
   - Test base classes
   - Integration test helpers

## Features

- User Authentication and Authorization
- Music Track Management
- Playlist Creation and Management
- Artist and Album Management
- User Profile Management
- Search Functionality
- Rating and Reviews System

## Prerequisites

- .NET 7.0 SDK
- PostgreSQL
- Visual Studio 2022 or VS Code
- Git

## Getting Started

1. Clone the repository
```bash
git clone https://github.com/yourusername/MusicApp.git
```

2. Update database connection string in `appsettings.json`
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=musicapp;Username=your_username;Password=your_password"
  }
}
```

3. Run database migrations
```bash
cd src/MusicApp
dotnet ef database update
```

4. Build and run the application
```bash
dotnet build
dotnet run
```

5. Access Swagger documentation at `https://localhost:5001/swagger`

## Development Guidelines

1. **Domain Layer First**
   - Start with domain entities in Core layer
   - Define interfaces for repositories and services

2. **Repository Pattern**
   - Implement repositories in DataAccess layer
   - Use repository interfaces from Core layer

3. **Service Layer**
   - Implement business logic in Application layer
   - Use DTOs for data transfer
   - Implement validation using FluentValidation

4. **API Controllers**
   - Keep controllers thin
   - Use service layer for business logic
   - Implement proper error handling

## Testing

The solution includes support for:
- Unit Testing
- Integration Testing
- Repository Testing
- Service Testing
- API Testing

Run tests using:
```bash
dotnet test
```

## Contributing

1. Fork the repository
2. Create your feature branch
```bash
git checkout -b feature/amazing-feature
```
3. Commit your changes
```bash
git commit -m 'Add some amazing feature'
```
4. Push to the branch
```bash
git push origin feature/amazing-feature
```
5. Open a Pull Request

## Design Patterns Used

- Repository Pattern
- Unit of Work
- Factory Pattern
- Dependency Injection
- Strategy Pattern
- Observer Pattern

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- ASP.NET Core Documentation
- Clean Architecture Principles
- Domain-Driven Design Concepts
