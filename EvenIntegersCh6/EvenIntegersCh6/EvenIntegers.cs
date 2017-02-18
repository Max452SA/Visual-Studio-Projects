// Fig 6.5: Sum.cs
// summing even integers using a for loop
using System;

public class EvenIntegers
{
    public static void Main()
    {
        int total = 0;

        for (int num = 2; num <= 20; num += 2)
        {
            total += num;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($" The sum of even integers is: {total}");
        Console.WriteLine();

    }// end Main
}// end class EvenIntegers