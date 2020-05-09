# This is a microservice used for: {{purpose}}

## Solution structure

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
 - A `.nuspec` file is included to generate and distribute the library as a Nuget Package
 - Written in `C#`
 - Target Framework: **Net Core 3.1**
 - Package dependencies: **Celerik.NetCore.HttpClient**
 - Project dependencies: **{{namespace}}.Model**
