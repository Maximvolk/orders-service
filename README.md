# Orders Service

Service provides users with ability to add order (with form) and see table of existing orders.

### Technologies
Used technoligies are: ASP.NET Core 5.0, EntityFramework (ORM), PostgreSQL (RDBMS)

While development PostgreSQL was launched in docker container (docker-compose file provided).

### Structure / architecture
Project structured in a 'Clean Architecture'-like (R.Martin) style.
Web presentation layer uses MVC.

### Possible improvements
- Unit tests.
- Use Unit Of Work pattern over Repositories to unify working with DB.

### How to run

I planned to provide single docker-compose file to launch all application with one command but it went wrong and now is not working yet.

To launch application you need to have Docker, docker-compose and dotnet5.0 sdk on your computer. Instructions on installation depend on your OS and can be easily found on official sites of specified products.

After you have Docker, docker-compose and dotnet SDK (5.0) you can run application with following steps (with commands in terminal or PowerShell):
1. Download repo to your computer. E.g. `git clone github.com/maximvolk/orders-service` (or via browser and github page)
2. Go to repo directory (orders-service, its location depends on where you downloaded it).
3. Launch PostgreSQL server `docker-compose up -d`
4. Go to directory with main project `cd OrdersService.Web`
5. Launch application `dotnet run`
6. Visit service at https://localhost:5001 (or http://localhost:5000).