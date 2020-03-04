namespace Domain.Product

open System
open System

type Product = {
    Id: Guid
    Title: string
}

type ProductOperationType =
    | Increment
    | Decrement

type ProductOperation = {
    Id: Guid
    ProductId: Guid
    Amount: int
    ShopId: Guid
    OperationType: ProductOperationType
}

module ProductCommands =
    let createProduct id title =
        let product = { Id = id; Title = title }
        product
        
    let createProductOperation id productId amount shopId operationType =
        let product = {
            Id = id
            ProductId = productId
            Amount = amount
            ShopId = shopId
            OperationType = operationType
        }
        product