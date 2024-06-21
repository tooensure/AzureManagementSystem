```
AzureManagementSystem
├── src
│   ├── AzureManagementSystem.Api // Web API project
│   │   ├── Controllers
│   │   │   ├── ResourcesController.cs
│   │   │   ├── RolesController.cs
│   │   │   └── UsersController.cs
│   │   ├── Startup.cs
│   │   ├── Program.cs
│   │   ├── appsettings.json
│   │   └── appsettings.Development.json
│   ├── AzureManagementSystem.Data // Data Access Layer (DAL)
│   │   ├── ResourcesRepository.cs
│   │   ├── RolesRepository.cs
│   │   ├── UsersRepository.cs
│   │   ├── DbContext.cs
│   │   └── Mappings // For database mapping (optional)
│   │       ├── ResourceMapping.cs
│   │       ├── RoleMapping.cs
│   │       └── UserMapping.cs
│   └── AzureManagementSystem.Core // Business Logic Layer (BLL)
│       ├── Services
│       │   ├── ResourceService.cs
│       │   ├── RoleService.cs
│       │   └── UserService.cs
│       └── Models 
│           ├── Resource.cs
│           ├── Role.cs
│           └── User.cs
│       └── Interfaces
│           ├── IResourcesRepository.cs
│           ├── IRolesRepository.cs
│           └── IUsersRepository.cs
├── tests
│   ├── AzureManagementSystem.Api.Tests
│   │   ├── Controllers
│   │   │   ├── ResourcesControllerTests.cs
│   │   │   ├── RolesControllerTests.cs
│   │   │   └── UsersControllerTests.cs
│   ├── AzureManagementSystem.Data.Tests
│   │   ├── ResourcesRepositoryTests.cs
│   │   ├── RolesRepositoryTests.cs
│   │   └── UsersRepositoryTests.cs
│   └── AzureManagementSystem.Core.Tests
│       ├── Services
│       │   ├── ResourceServiceTests.cs
│       │   ├── RoleServiceTests.cs
│       │   └── UserServiceTests.cs
└── .gitignore