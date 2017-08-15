
using System;

public static class Bank
{
    public static void Main()
    {
        var bank = new BankAccount();

        bank.ID = 1;
        bank.Deposit(15);
        bank.Withdraw(5);

        Console.WriteLine(bank.ToString());
    }
}
