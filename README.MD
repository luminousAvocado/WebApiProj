# Web API Demo

This is a demo of a Web API using ASP .NET Core, Entity Framework Core, and SQL Server.

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
