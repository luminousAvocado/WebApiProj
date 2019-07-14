# Web API Demo

This is a demo of a Web API using ASP .NET Core, Entity Framework Core, SQL Server, and Auth0.

## Setup

1. Clone repo
2. Run the following commands from within the project folder to create the database:
```
    $ dotnet ef migrations add InitialSchema
    $ dotnet ef database update
```
If you have an old database, you should drop it first either manually or using the following command:
```
    $ dotnet ef database drop
```
The appsettings.json must also be modified for database connection and Auth0 settings
