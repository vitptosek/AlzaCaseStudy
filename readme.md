<img src="Src\Presentation\WebApi\alza.ico" align="right" width="64" />

# Case study 
> WebApi Application

REST API service providing all available products of an eshop and enabling the partial update of one product

## About the application

- This is to demonstrate a chosen multi-layer approach to a backend development of some trivial Eshop providing basic functionality upon products such as:
  - Queries
    - Get product detail (based on filter)
    - Get list of products (based on filter, availability) and its pagination in higher version
  - Commands  
    - Partial update of a product (based on filter and entity state)

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
- AutoMapper, CQRS, Dependency Injection, FluentValidation, MediatR, Swagger, X.PagedList, xUnit

## Prerequisites 

For building and running the project one needs to have installed following

- .NET Core framework (use the most recent LTS version) and C# (latest version is nice)
- MSSQL DBMS

Steps

- Pull for the latest version of Master branch
- Rebuild the solution to make sure all of the packages are there
- Update-Database to keep up with the most recent migration in the project
- Set WebApi to be your startup project and watch things happen on localhost:5000

## License

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)

To the extent possible under law, [Vit Ptosek](https://github.com/vitptosek) has waived all copyright and related or neighboring rights to this work.
