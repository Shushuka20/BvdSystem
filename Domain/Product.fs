namespace Domain.Product

open System

type Product = {
    Id: Guid
    Title: string
}

module ProductOperations =
    let create id title =
        let product = { Id = id; Title = title }
        product