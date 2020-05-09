# This is a microservice used for: {{purpose}}

## Quick Startup

### Building the solution
```shell
cd source
dotnet build {{namespace}}.Api.sln
```

### Running unit tests
```shell
cd source
dotnet test {{namespace}}.Api.sln
```

### Running the API
```shell
cd source
cd {{namespace}}.Api
dotnet run --launch-profile {{namespace}}.Api
```

### Environment variables
 - **ASPNETCORE_ENVIRONMENT**: Allowed values:
    - `Local`
    - `Development`
    - `QA`
    - `Staging`
    - `Production`
 - **ServiceType**: Allowed values:
    - `ServiceMock`: Runs the service in mock mode
    - `ServiceEF`: Runs the service in real mode (EF is shortcut for **Entity Framework**)
 - **Logging__Provider**: Allowed values:
    - `Console`
    - `Debug`
    - `EventSource`
    - Any comma-separated combination is also allowed. E.g.: `Console,Debug,EventSource`
 - **ConnectionStrings__SqlServer**: The SqlServer connection string

## Solution architecture

<div align="center">
    <img src="images/architecture.png" alt="Architecturee" width="916" />
</div>

## source/**{{namespace}}.Api** Project

 - This project exposes **RESTFul** services through **Swagger UI** and **OpenAPI** following a **Microservice Architecture**.
 - Configuration files for the following environments are provided: **Local**, **Development**, **QA**, **Staging**, **Production**
 - Written in `C#`
 - Target Framework: **Net Core 3.1**
 - Package dependencies: **Celerik.NetCore.Web**, **Microsoft.EntityFrameworkCore.Tools**
 - Project dependencies: **{{namespace}}.Services**
 
## source/{{namespace}}.HttpClient Project

 - This is an HttpClient to facilitate consuming the **{{namespace}}.Api** microservice from anywhere (mobile app, other microservices)
 - A `.nuspec` file is included to generate and distribute the library as a **Nuget Package**
 - Written in `C#`
 - Target Framework: **Net Core 3.1**
 - Package dependencies: **Celerik.NetCore.HttpClient**
 - Project dependencies: **{{namespace}}.Model**
