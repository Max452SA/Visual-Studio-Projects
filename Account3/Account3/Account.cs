// Fig 4.8: Account.cs
// Account class with a constructor that initialises an Account's Name

using System;

public class Account
{
    public string Name { get; set; }  //auto-implemented property 

    //Constructor for class Account
    public Account(string accountName)
    {
        Name = accountName;
    }
}// end class Account