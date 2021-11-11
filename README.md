![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Sever-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
![Postman](https://img.shields.io/badge/Postman-FF6C37?style=for-the-badge&logo=postman&logoColor=white)

A C# Web CRUD API using ASP.NET Core and SQL Server 2019 & SQL Server Management Studio, with Entity Framework Core as ORM, that stores CLI commands for different platforms.

Credit: [Les Jackson](https://www.youtube.com/watch?v=fmvcAzHpsk8) \
Repo: [binarythistle](https://github.com/binarythistle/S03E02---.NET-Core-3.1-MVC-REST-API)

## Routes

| HTTP Method | Function           | Endpoint             | Completed |
| ----------- | ------------------ | -------------------- | --------- |
| GET         | List all Commands  | `/api/commands`      | Y         |
| GET         | List Command by ID | `/api/commands/{id}` | Y         |
| POST        | Create a Command   | `/api/commands`      | Y         |

## User secrets

Password for db set with:

`dotnet user-secrets init` \
`dotnet user-secrets set "<secret key>" "<secret value>"` \
`dotnet user-secrets list`

Added to startup before DbContext:

```C#
var builder = new SqlConnectionStringBuilder(
    Configuration.GetConnectionString("CommanderConnection")
);
builder.Password = Configuration.GetSection("DBPassword").Value;
var connectionString = builder.ConnectionString;

services.AddDbContext<CommanderContext>(opt => opt.UseSqlServer(connectionString));
```
