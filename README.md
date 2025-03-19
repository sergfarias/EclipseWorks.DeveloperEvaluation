# Developer Evaluation Project

`READ CAREFULLY`

## Instructions
**The test below will have up to 7 calendar days to be delivered from the date of receipt of this manual.**

- The code must be versioned in a public Github repository and a link must be sent for evaluation once completed
- Upload this template to your repository and start working from it
- Read the instructions carefully and make sure all requirements are being addressed
- The repository must provide instructions on how to configure, execute and test the project
- Documentation and overall organization will also be taken into consideration

## Use Case
**You are a developer on the DeveloperStore team. Now we need to implement the API prototypes.**

As we work with `DDD`, to reference entities from other domains, we use the `External Identities` pattern with denormalization of entity descriptions.

Therefore, you will write an API (complete CRUD) that handles sales records. The API needs to be able to inform:

* Sale number
* Date when the sale was made
* Customer
* Total sale amount
* Branch where the sale was made
* Products
* Quantities
* Unit prices
* Discounts
* Total amount for each item
* Cancelled/Not Cancelled

It's not mandatory, but it would be a differential to build code for publishing events of:
* SaleCreated
* SaleModified
* SaleCancelled
* ItemCancelled

If you write the code, **it's not required** to actually publish to any Message Broker. You can log a message in the application log or however 
you find most convenient.

### Business Rules

* Purchases above 4 identical items have a 10% discount
* Purchases between 10 and 20 identical items have a 20% discount
* It's not possible to sell above 20 identical items
* Purchases below 4 items cannot have a discount

These business rules define quantity-based discounting tiers and limitations:

1. Discount Tiers:
   - 4+ items: 10% discount
   - 10-20 items: 20% discount

2. Restrictions:
   - Maximum limit: 20 items per product
   - No discounts allowed for quantities below 4 items

## Overview
This section provides a high-level overview of the project and the various skills and competencies it aims to assess for developer candidates. 

See [Overview](/.doc/overview.md)

## Tech Stack
This section lists the key technologies used in the project, including the backend, testing, frontend, and database components. 

See [Tech Stack](/.doc/tech-stack.md)

## Frameworks
This section outlines the frameworks and libraries that are leveraged in the project to enhance development productivity and maintainability. 

See [Frameworks](/.doc/frameworks.md)

<!-- 
## API Structure
This section includes links to the detailed documentation for the different API resources:
- [API General](./docs/general-api.md)
- [Products API](/.doc/products-api.md)
- [Carts API](/.doc/carts-api.md)
- [Users API](/.doc/users-api.md)
- [Auth API](/.doc/auth-api.md)
-->

## Project Structure
This section describes the overall structure and organization of the project files and directories. 

See [Project Structure](/.doc/project-structure.md)










##Testes/Dicas candidato Sergio Farias
1 - USEI SQL EXPRESS COMO BD

2 - NO PACKGE MANAGER CONSOLE RODAR O MIGRATIONS
PROJ:Adapters\Drivers\WebApi\Ambev.DeveloperEvaluation.WebApi
add-migration Inicio -Context Context -verbose
update-database Incio 

3 - CARGA BD:
INSERT INTO [dbo].[Customers] (id, Name, CreatedAt) VALUES('3fa85f64-5717-4562-b3fc-2c963f66afa5','Cliente1', GETDATE())
INSERT INTO [dbo].[Customers] (id, Name, CreatedAt) VALUES('3fa85f64-5717-4562-b3fc-2c963f66afa6','Cliente2', GETDATE())
INSERT INTO [dbo].[Branchs] (id, Name, CreatedAt) VALUES('3fa85f64-5717-4562-b3fc-2c963f66afa7','Filial1', GETDATE())
INSERT INTO [dbo].[Branchs] (id, Name, CreatedAt) VALUES('3fa85f64-5717-4562-b3fc-2c963f66afa8','Filial2', GETDATE())
INSERT INTO [dbo].[Products] (id, Name, Price, CreatedAt) VALUES('3fa85f64-5717-4562-b3fc-2c963f66afa9','Lapís','3.50', GETDATE())
INSERT INTO [dbo].[Products] (id, Name, Price, CreatedAt) VALUES('3fa85f64-5717-4562-b3fc-2c963f66afa1','Borracha','4.50', GETDATE())
INSERT INTO [dbo].[Products] (id, Name, Price, CreatedAt) VALUES('3fa85f64-5717-4562-b3fc-2c963f66afa2','Caneta','5.50', GETDATE())


4 - TESTES SWAGGER
4.1 - NO SWAGGER CRIAR UMA NOTA COM DOIS ITENS
{
  "saleNumber": "1234",
  "saleDate": "2025-03-17T23:41:07.226Z",
  "customerId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "branchId": "3FA85F64-5717-4562-B3FC-2C963F66AFA8",
  "saleItem": [
    {
      "productId": "3FA85F64-5717-4562-B3FC-2C963F66AFA1",
	   "quantities": 4
    },
	{
      "productId": "3FA85F64-5717-4562-B3FC-2C963F66AFA2",
	  "quantities": 5
    }
  ]
}

4.2 - NO SWAGGER ALTERAR UM NOTA PARA APENAS UM ITEM - EM ID COLOCAR O ID GERADO ACIMA
{
  "id": "22812DC4-1B02-4FED-8965-388E78D62A13",
  "saleNumber": "1234",
  "saleDate": "2025-03-18T22:14:13.437Z",
  "customerId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "branchId": "3FA85F64-5717-4562-B3FC-2C963F66AFA8",
  "saleItem": [
    {
      "productId": "3FA85F64-5717-4562-B3FC-2C963F66AFA9",
      "quantities": 10
    }
  ]
}

4.3 - NO SWAGGER CRIAR UMA NOTA COM UM ITEM
* Purchases above 4 identical items have a 10% discount
{
  "saleNumber": "1234",
  "saleDate": "2025-03-17T23:41:07.226Z",
  "customerId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "branchId": "3FA85F64-5717-4562-B3FC-2C963F66AFA8",
  "saleItem": [
    {
      "productId": "3FA85F64-5717-4562-B3FC-2C963F66AFA1",
	   "quantities": 5
    }
  ]
}


4.4 - NO SWAGGER CRIAR UMA NOTA COM UM ITEM
* Purchases between 10 and 20 identical items have a 20% discount
{
  "saleNumber": "1234",
  "saleDate": "2025-03-17T23:41:07.226Z",
  "customerId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "branchId": "3FA85F64-5717-4562-B3FC-2C963F66AFA8",
  "saleItem": [
    {
      "productId": "3FA85F64-5717-4562-B3FC-2C963F66AFA1",
	   "quantities": 11
    }
  ]
}


4.5 - NO SWAGGER CRIAR UMA NOTA COM UM ITEM
* It's not possible to sell above 20 identical items
{
  "saleNumber": "1234",
  "saleDate": "2025-03-17T23:41:07.226Z",
  "customerId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "branchId": "3FA85F64-5717-4562-B3FC-2C963F66AFA8",
  "saleItem": [
    {
      "productId": "3FA85F64-5717-4562-B3FC-2C963F66AFA1",
	   "quantities": 21
    }
  ]
}


4.6 - NO SWAGGER CRIAR UMA NOTA COM UM ITEM
* Purchases below 4 items cannot have a discount
{
  "saleNumber": "1234",
  "saleDate": "2025-03-17T23:41:07.226Z",
  "customerId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "branchId": "3FA85F64-5717-4562-B3FC-2C963F66AFA8",
  "saleItem": [
    {
      "productId": "3FA85F64-5717-4562-B3FC-2C963F66AFA1",
	   "quantities": 21
    }
  ]
}

