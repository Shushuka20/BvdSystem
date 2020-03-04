namespace Domain.Shop

open System

type Shop = {
    Id: Guid
    Title: string
}

module ShopCommands =
    let createShop id title =
        let shop = { Id = id; Title = title }
        shop