using System;

public static class Bank
{
    public static void Main()
    {
        var bank = new BankAccount();

        bank.ID = 1;
        bank.Balance = 15;

        Console.WriteLine($"Account {bank.ID}, balance {bank.Balance}");
    }
}
