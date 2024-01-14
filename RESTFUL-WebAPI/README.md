# ToDo App

### Description :

- Outlines the RESTful API architecture used for the ToDo app.
- Covers key API endpoints, request/response formats, and authentication mechanisms.

```
.
└── TodoApp/
    ├── Configuration/
    │   ├── AuthResult.cs
    │   └── JwtConfig.cs
    ├── Controllers/
    │   └── Auth/
    │       ├── AuthManagementController.cs
    │       └── TodoController.cs
    ├── Data/
    │   └── ApiDbContext.cs
    ├── Migrations
    ├── Models/
    │   ├── DTOs/
    │   │   ├── Requests/
    │   │   │   ├── TokenRequest.cs
    │   │   │   ├── UserLoginRequest.cs
    │   │   │   └── UserRegistrationDto.cs
    │   │   ├── Responses/
    │   │   │   ├── LoginResponse.cs
    │   │   │   ├── RegistrationResponse.cs
    │   │   │   └── TodoResponse.cs
    │   │   ├── ItemData.cs
    │   │   └── RefreshToken.cs
    │   └── Services/
    │       ├── ITodoService.cs
    │       └── TodoService.cs
    ├── Program.cs
    ├── Startup.cs
    └── README.md
```

### Directories

- `Configuration`, stores configuration files that hold application-wide settings and preferences.
- `Controllers`, houses controller classes that handle incoming requests and orchestrate responses.
- `Models`, contains model classes that represent the core data entities of the application.
- `Data`, stores static data files used by the application.

### Auth Management

### Todo Services
