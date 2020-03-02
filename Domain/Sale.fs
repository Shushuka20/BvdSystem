module Domain.Sale

open Domain.Money
open System

type SaleProduct = {
    ProductId: int
    SaleId: int
}

type Buyer =
    | Regular
    | Partner of int

type MoneyInformation = {
    Sum: decimal
    Discount: decimal
    Operations: seq<MoneyOperation>
}

type SaleFromStock = {
    DateTime: DateTime
    Comment: string
    Products: seq<SaleProduct>    
}