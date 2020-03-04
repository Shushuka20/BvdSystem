namespace Domain.Supply

open System

type Supplier = {
    Id: Guid
    Title: string
}

type SupplyProduct = {
    Id: Guid
    SupplyId: Guid
    ProductId: Guid
    Amount: int
}

type Supply = {
    Id: Guid
    SupplierId: Guid
    DateTime: DateTime
    Products: seq<SupplyProduct>
    ShopId: Guid
}

module SupplyCommands =
    let createSupply id supplierId datetime shopId products =
        let supply = {
            Id = id
            SupplierId = supplierId
            DateTime = datetime
            ShopId = shopId
            Products = products
        }
        supply