// Fig 3.14: Addition.cs
// simple beginner program that Displays the sum of two integers from the keyboard

using System;

class Addition
{
    public static void Main()
    {
        int number1;    //1st integer variable to add 
        int number2;    //2nd integer variable to add
        int sum;        //declaration of the sum of number1 and number2

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("  Please enter the 1st integer: ");
        //read in the 1st number from the user
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine(" Please enter the 2nd integer: ");
        //read in the 2nd number from the user
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine();
        Console.WriteLine($" The sum of the two numbers is: {sum} ");
        Console.WriteLine();
    } //end Main Method
} //end class Addition
