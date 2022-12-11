// See https://aka.ms/new-console-template for more information
using State;

Console.Title = "State Pattern";

BankAccount bankAccount = new ();
bankAccount.Deposit(100);
bankAccount.Withdraw(500);
bankAccount.Withdraw(100);

bankAccount.Deposit(2000);
bankAccount.Deposit(100);

bankAccount.Withdraw(3000);
bankAccount.Deposit(3000);
bankAccount.Deposit(100);

Console.ReadKey();

