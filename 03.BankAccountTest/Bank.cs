using System;
using System.Collections.Generic;

public static class Bank
{
    public static void Main()
    {
        string input;
        var accounts = new Dictionary<int, BankAccount>();

        while ((input = Console.ReadLine()) != "End")
        {
            var commandParams = input.Split();

            var command = commandParams[0];

            switch (command)
            {
                case "Create":
                    Create(commandParams, accounts);
                    break;
                case "Deposit":
                    Deposit(commandParams, accounts);
                    break;
                case "Withdraw":
                    Withdraw(commandParams, accounts);
                    break;
                case "Print":
                    Print(commandParams, accounts);
                    break;
            }
        }
    }

    private static void Print(string[] commandParams, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(commandParams[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }
        else
        {
            PrintError();
        }
    }

    private static void Withdraw(string[] commandParams, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(commandParams[1]);
        if (accounts.ContainsKey(id) && accounts[id].Balance >= double.Parse(commandParams[2]))
        {
            accounts[id].Withdraw(double.Parse(commandParams[2]));
        }
        else if (!accounts.ContainsKey(id))
        {
            PrintError();
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }


    }

    private static void Deposit(string[] commandParams, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(commandParams[1]);
        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(double.Parse(commandParams[2]));
        }
        else
        {
            PrintError();
        }
    }

    private static void PrintError()
    {
        Console.WriteLine("Account does not exist");
    }

    private static void Create(string[] commandParams, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(commandParams[1]);
        if (!accounts.ContainsKey(id))
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id, acc);
        }
        else
        {
            Console.WriteLine("Account already exists");
        }

    }
}
