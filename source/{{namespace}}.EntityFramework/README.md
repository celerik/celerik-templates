# {{namespace}}.EntityFramework

## About

This project provides SqlServer data access using Entity Framework with the Database-First approach.
    
## Steps to update Entity Framework entities in Visual Studio 2019:

    1. Select the Api project as the Startup project.

    2. Build the solution, it must be compiling.

    3. Go to top menu, Tools > NugetPackage Manager > Package Manager Console.

    5. On "Default project", select this project.
    
    6. Run the following command:
	   Scaffold-DbContext "server={{db-server}};Database={{db-catalog}};User={{db-user}};Password={{db-password}}" Microsoft.EntityFrameworkCore.SqlServer -Context {{short-namespace}}DbContext
       
    7. Once the code is generated Visual Studio opens {{short-namespace}}DbContext.cs file,
       on that file, remove "OnConfiguring" method:

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ...
        }

    8. Replace files in "CodeGeneration" folder for the ones generated in root folder.

    9. Remove entities that are not part of this model, update DbContext as well.