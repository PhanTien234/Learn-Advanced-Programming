
// See https://aka.ms/new-console-template for more information
using Lab1;
using System;

Console.WriteLine("Hello, World!");
//print to console
//Lab_1();
Lab_3();

static void Lab_1()
{
    BankAccount bankAccount = new BankAccount();
    bankAccount.Id = 1;
    bankAccount.Balance = 15;
    Console.WriteLine($"Account{bankAccount.Id}, balance {bankAccount.Balance}");

}
static void Lab_2()
{
    BankAccount bankAccount = new BankAccount();
    bankAccount.Id = 3;
    bankAccount.Deposit(15);
    bankAccount.Withdraw(10);
    Console.WriteLine(bankAccount);
}
static void Lab_3()
{
    Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
    do
    {
        string command = Console.ReadLine();
        var cmdArgs = command.Split();
        switch (cmdArgs[0])
        {
            case "Create":
                Create(cmdArgs, accounts);
                break;
            case "Deposit":
                Deposit(cmdArgs, accounts);
                break;
            case "Withdraw":
                Withdraw(cmdArgs, accounts);
                break;
            case "Print":
                Print(cmdArgs, accounts);
                break;
        }
        if (cmdArgs[0] == "End")
        {
            break;
        }
    } while (true);

}
 static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
{
    var id = int.Parse(cmdArgs[1]);
    if (!accounts.ContainsKey(id))
    {
        Console.WriteLine("Accound does not exist");
    }
    else
    {
        var acc = accounts[id];
        Console.WriteLine(acc);
    }
}

 static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
{
    var id = int.Parse(cmdArgs[1]);
    if (!accounts.ContainsKey(id))
    {
        Console.WriteLine("Accound does not exist");
    }
    else
    {
        var acc = accounts[id];
        var amount = decimal.Parse(cmdArgs[2]);
        acc.Withdraw(amount);
    }
}

 static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
{
    var id = int.Parse(cmdArgs[1]);
    if (!accounts.ContainsKey(id))
    {
        Console.WriteLine("Accound does not exist");
    }
    else
    {
        var acc = accounts[id];
        var amount = decimal.Parse(cmdArgs[2]);
        acc.Deposit(amount);
    }
}
 static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
{
    var id = int.Parse(cmdArgs[1]);
    if (accounts.ContainsKey(id))
    {
        Console.WriteLine("Accound already exists");
    }
    else
    {
        var acc = new BankAccount();
        acc.Id = id;
        accounts.Add(id, acc);
    }
}