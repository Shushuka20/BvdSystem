module Domain.Money

type OperationType = Cash | Cashless

type Income = {
    Sum: decimal
    Type: OperationType
    CashboxId: int
}

type Expense = {
    Sum: decimal
    Type: OperationType
    CashboxId: int
}

type MoneyOperation =
    | Income of Income
    | Expense of Expense