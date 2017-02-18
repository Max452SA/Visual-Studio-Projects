// Fig 4.1: AccountTest.cs
// Creating and manipulating a simple account object

using System;
public class AccountTest
{
    public static void Main()
    {
        //create an Account object and assign it the name myAccount
        Account myAccount = new Account();

        Console.WriteLine();
        Console.WriteLine();
        //display myAccount's initial name (will only work after an initial name is added to myAccount class)
        Console.WriteLine($"  Initial Name of Account is: {myAccount.GetName()}");

        //prompt for and read the Account name, then put the name in the object
        Console.Write("  Please enter the Account holder's name: ");
        string theName = Console.ReadLine();
        myAccount.SetName(theName);   //stores account holder's name in the myAccount object

        //display the name stored in the myAccount object
        Console.WriteLine($"  myAccount's name is: {myAccount.GetName()}");
        Console.WriteLine();
        Console.WriteLine();

    }//end Main method
}//end class AccountTest
