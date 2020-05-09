
## source/{{namespace}}.EntityFramework Project

 - This project exposes a **DbContext** using the *Database-First approach*
 - Written in `C#`
 - Target Framework: **Net Standard 2.1**
 - Package dependencies: **Microsoft.EntityFrameworkCore.SqlServer**
 
 ### Steps to update Entity Framework entities in Visual Studio 2019:
 
  1. Select the main project (Api, Console, etc.) as the Startup project
  2. Build the solution, it must be compiling
  3. Go to top menu, **Tools** > **NugetPackage Manager** > **Package Manager Console**
  4. On **Default project** select **{{namespace}}.EntityFramework**
  5. Run the following command:
  ```cs
  Scaffold-DbContext "server={{db-server}};Database={{db-catalog}};User={{db-user}};Password={{db-password}}" Microsoft.EntityFrameworkCore.SqlServer -Context {{short-namespace}}DbContext
  ```
  6. Once the code is generated Visual Studio opens `{{short-namespace}}DbContext.cs` file, on that file, remove `OnConfiguring` method:
  ```cs
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    ...
  }
  ```
  7. Replace files in `CodeGeneration` folder for the ones generated in root folder
  8. Remove entities that are not part of this model, update **DbContext** as well
