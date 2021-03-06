<img src="Src\Presentation\WebApi\alza.ico" align="right" width="64" />

# Case study 
> WebApi Application

REST API service providing all available products of an eshop and enabling the partial update of one product

## About the application

- This is to demonstrate a chosen multi-layer approach to a backend development of some trivial Eshop providing basic functionality upon products such as:
  - Queries
    - Get product detail (based on filter)
    - Get list of products (based on filter, availability) 
      - List is paginated in higher version (based on ordering by identifier - criterion can be changed)
  - Commands  
    - Partial update of a product (based on filter and entity state)
- Documentation
- Multi-level testing
- Some other features like logging have also been implemented

## Architecture

### Literature

- ["Clean Architecture: A Craftsman's Guide to Software Structure and Design"](https://books.google.cz/books/about/Clean_Architecture.html?id=8ngAkAEACAAJ) (*Robert C. Martin*)

### Design patterns

- [CQRS](https://martinfowler.com/bliki/CQRS.html) - Command Query Responsibility Segregation (*Martin Fowler*)
- [Mediator](https://en.wikipedia.org/wiki/Mediator_pattern) - A behavioral patter for object interactio that works nicely with [CQRS](https://medium.com/@letienthanh0212/cqrs-and-mediator-in-net-core-project-c0b477eab6e9)

## Tools

Technology and packages used in the project

- C# / .NET Core
- Entity Framework Core / MSSQL
- FluentValidation, Moq, Shouldly, xUnit
- AutoMapper, CQRS, Dependency Injection, MediatR, Swagger, X.PagedList

## Prerequisites 

For building and running the project one needs to have installed following

- .NET Core framework - use the most recent LTS version and C# (latest version is nice)
- DBMS - preferably MSSQL as per request set for te project (or being dependant on InMemoryDb)
- Visual Studio - .NET Core 3.0 requires 
  - Visual Studio 2019 (v16. 3 or later)
  - Visual Studio 2019 for Mac (v8. 3 or later)

## Steps how to launch

#### The project from Visual Studio

- Pull for the latest version of Master branch
- Rebuild the solution to make sure all of the packages are there
- Update-Database to keep up with the most recent migration in the project
- Set WebApi to be your startup project and watch things happen on following endpoints
  - Swagger: [localhost:5000/swagger](http://localhost:5000/swagger/index.html)
  - Database health check: [localhost:5000/health/db/alza](http://localhost:5000/health/db/alza) (should indicate Healthy)
  - Actual WebApi corresponding to Swagger: localhost:5000/api/v\<version>/\<Controller>/\<Action> 
    - Version 1 
      - [example](http://localhost:5000/api/v1/Product/GetAvailable) - all products
    - Version 2 
      - [example](http://localhost:5000/api/v2/Product/GetAvailable/1) - all products paginated (first page by 10 products)
      - [example](http://localhost:5000/api/v2/Product/GetAvailable/1/15) - all products paginated (first page by 15 products)
      - [example](http://localhost:5000/api/v2/Product/GetAvailable/2/2) - all products paginated (second page by 2 products)

#### The project from command line 
- Choose root folder
  - at root directory ```git pull```
  - at root directory
```dotnet clean```, ```dotnet restore```, then ```dotnet build```
- Go all the way down to ..\Eshop\Src\Presentation\WebApi folder
  - in WebApi folder ```dotnet run``` to launch Kestrel Console App and Web Api
 
#### Unit tests
- In Visual Studio - Find Test explorer, then Run All Tests and it should all go green
- From a command line - ```dotnet test```, for more options please see [documentation](https://docs.microsoft.com/cs-cz/dotnet/core/tools/dotnet-test)

Currently, there should be fiveteen tests in the solution included covering
  - Domain
  - Application
  - Persistence/Integration

#### Database
The complete database-related work should be taken care of itself thanks to migrations that are part of this project.
However, if you wish to see "the raw data" you should be able to connect via connection string provided in *appsetting.json* of a Presentation layer, i.e. *WebApi* using e.g. Microsoft SQL Server Management Studio.

- Database name: *AlzaDb*
- Database scheme: *Eshop*

Database query example - select providing all of not soft-deleted Products being available in at least one Store and listing their total count combined.

```sql
SELECT product.Name AS Product,
       COUNT(product.Name) AS Count
FROM Eshop.Products product 
JOIN Eshop.StoreProducts sp 
     ON product.Guid=sp.ProductId 
WHERE product.IsDeleted = 0
GROUP BY product.Name
ORDER BY 2 DESC;
```

Something very similar is used with help of EF Core to achieve in *Product/GetAvailable* endpoint.
## License

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)

To the extent possible under law, [Vit Ptosek](https://github.com/vitptosek) has waived all copyright and related or neighboring rights to this work. Happy coding.
