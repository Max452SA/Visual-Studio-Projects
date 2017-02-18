// Fig 4.12: AccountTest.cs
// Reading and writing monetary amounts with Account Objects

using System;

public class AccountTest
{
    public static void Main()
    {
        Account account1 = new Account("Jane Green", 50.00m);
        Account account2 = new Account("John Blue", -7.53m);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($" {account1.Name}'s balance is: {account1.Balance:C}");
        Console.WriteLine($" {account2.Name}'s balance is: {account2.Balance:C}");
        Console.WriteLine();

        Console.Write(" Enter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($" adding {depositAmount:C} to account1\n");
        account1.Deposit(depositAmount);

        Console.WriteLine($" {account1.Name}'s balance is: {account1.Balance:C} ");
        Console.WriteLine($" {account2.Name}'s balance is: {account2.Balance:C} ");

        Console.WriteLine();
        Console.WriteLine();
        Console.Write(" Enter deposit amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($" adding {depositAmount:C} to account2\n");
        account2.Deposit(depositAmount);

        Console.WriteLine($" {account1.Name}'s balance is: {account1.Balance:C} ");
        Console.WriteLine($" {account2.Name}'s balance is: {account2.Balance:C} ");
        Console.WriteLine();

    }// end Main
}// end class AccountTest
