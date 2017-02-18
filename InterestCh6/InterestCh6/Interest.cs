// Fig 6.6: Interest.cs
// Compound Interest calculations using a for loop
using System;

public class Interest
{
    public static void Main()
    {
        decimal principal = 1000;
        double interestRate = 0.05;

        Console.WriteLine();
        Console.WriteLine("  Year        Amount on Deposit (interest added) ");
        Console.WriteLine();
        Console.WriteLine();

        for (int year = 1; year <= 10; year++)
        {
            decimal amount = principal * ((decimal) Math.Pow(1.0 + interestRate, year));
            // calculates the interest earned for the year and adds it to local variable amount
            //using the formula a = Principal(1 + r)^year

            Console.WriteLine($"{year,5} {amount,25:C}");
        }
        Console.WriteLine();
    }// end Main
}// end class Interest