# Project Information


## Yuxi.Devops.Assessment.API: 
Rest API built using ASP.NET core 2.0 
  * Build command: ```dotnet build Yuxi.Devops.Assessment.API.csproj```
  * Publish command: ```dotnet publish Yuxi.Devops.Assessment.API.csproj --configuration -release --output ./releaseFolder```
  * Database credentials : appsettings.json > ConnectionStrings.DatabaseConnectionString
  
## Yuxi.Devops.Assessment.UnitTests.csproj: 
Unit tests built using .netcore and MSTest runner
  * Test command: ```dotnet test Yuxi.Devops.Assessment.UnitTests.csproj```
  
## Yuxi.Devops.Assessment.Database: 
SQL Server Database project for Azure SQL
  * Build command: must be build using MSBuild > 15.0 
  * Deployment : Apply the DAC package to the database.
  
## Running example 
  * Health Check:  [HTTP GET /HealtCheck ](https://yuxi-assessments-devops-backend.azurewebsites.net/HealthCheck)
  * Drivers : [HTTP GET /api/drivers](https://yuxi-assessments-devops-backend.azurewebsites.net/api/drivers) 


