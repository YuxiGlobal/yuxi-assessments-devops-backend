# Project Information


## Yuxi.Devops.Assessment.API: 
Rest API built using ASP.NET core 2.0 
  * build command: ```dotnet build Yuxi.Devops.Assessment.API.csproj```
  * publish command: ```dotnet publish Yuxi.Devops.Assessment.API.csproj --configuration -release --output ./releaseFolder```
  * Healt Check Endpoint: HTTP GET /HealtCheck 
  
## Yuxi.Devops.Assessment.UnitTests.csproj: 
Unit tests built using .netcore and MSTest runner
  * test command: ```dotnet test Yuxi.Devops.Assessment.UnitTests.csproj```
  
## Yuxi.Devops.Assessment.Database: 
SQL Server Database project for Azure SQL
  * build command: must be build using MSBuild > 15.0 
  
## Running example 
Here you can find a functional release of the application: https://yuxi-assessments-devops-backend.azurewebsites.net
  * Health Check:  [HTTP GET /HealtCheck ](https://yuxi-assessments-devops-backend.azurewebsites.net/HealthCheck)
  * Drivers : [HTTP GET /api/drivers](https://yuxi-assessments-devops-backend.azurewebsites.net/api/drivers) 


