namespace Domain.Sale

open Domain.Money
open System

type SaleProduct = {
    ProductId: int
    Amount: int
}

type Buyer =
    | Regular
    | Partner of int

type MoneyInformation = {
    Sum: decimal
    Discount: decimal
    Operations: seq<MoneyOperation>
}

type SaleFromShop = {
    DateTime: DateTime
    Products: seq<SaleProduct>    
}

module SaleCommands =
    
    let createSaleFromShop (dateTime: DateTime, products: seq<SaleProduct>) =
        let sale = {DateTime = dateTime; Products = products}
        sale