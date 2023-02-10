# WEB315-_ASSIGNMENT1
## Name: Haider Ali
## ID: 0828832
Assignment 1 - A Pizza website which shows different kind of Pizzas

 ## EF Tools and NuGet packages commands
 dotnet tool install --global dotnet-ef --version 5
 dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
 dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
 dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
 dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
 dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

 ## Scaffold the model
 dotnet-aspnet-codegenerator razorpage -m Pizza -dc RazorPagesPizzaContext -udl -outDir Pages/Pizzas --referenceScriptLibraries -sqlite

 ## Created the initial database schema using EF's migration feature
 dotnet ef migrations add InitialCreate
 dotnet ef database update