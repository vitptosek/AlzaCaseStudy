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

- .NET Core framework (use the most recent LTS version) and C# (latest version is nice)
- MSSQL DBMS

Steps

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

## License

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)

To the extent possible under law, [Vit Ptosek](https://github.com/vitptosek) has waived all copyright and related or neighboring rights to this work.
