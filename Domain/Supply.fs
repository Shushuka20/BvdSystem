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
    SupplierId: Guid
    DateTime: DateTime
    Products: seq<SupplyProduct>
    ShopId: Guid
}