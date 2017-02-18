// Fig 4.5: AccountTest2.cs
// Creating and manipulating an Account object with properties.
using System;

public class AccountTest2
{
    public static void Main()
    {
        Account myAccount = new Account();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($" Initial Name is: {myAccount.Name}");

        Console.Write(" Please enter a name: ");
        string theName = Console.ReadLine();
        myAccount.Name = theName;

        Console.WriteLine($" myAccount's name is: {myAccount.Name}");
        Console.WriteLine();
        Console.WriteLine();

    }// end Main method
}// end class AccountTest2