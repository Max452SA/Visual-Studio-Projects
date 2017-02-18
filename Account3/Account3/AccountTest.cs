// Fig 4.9: AccountTest.cs
// Using the Account constructor to set an Account's name
// when an Account object is created

using System;

public class AccountTest
{
    public static void Main()
    {
        Account account1 = new Account(" Jane Green ");
        Account account2 = new Account(" Mridul Maharaj ");

        // display the initial values of name for each new Account Object
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($" Account1 name is: {account1.Name} ");
        Console.WriteLine($" Account2 name is: {account2.Name} ");
        Console.WriteLine();

    }// end Main
}// end class AccountTest