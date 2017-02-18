// fig 5.8: ClassAverage.cs
// Solving the Class-average problem using sentinel controlled iteration.
using System;

public class ClassAverage
{
    public static void Main()
    {
        // variable initialization
        int total = 0;
        int counter = 0;
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("  Please enter a grade or -1 to quit: ");
        int grade = int.Parse(Console.ReadLine());

        while (grade != -1)
        {
            total += grade;  //adds the value of grade to value stored in total
            counter++;

            //prompt user for next input grade and test the loop again
            Console.Write("  Please enter a Grade or -1 to quit: ");
            grade = int.Parse(Console.ReadLine());

        } //end while

        if (counter != 0)
        {
            double average = (double)total / counter; //casting to double to calc average

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"  Total of all grades: {total}");
            Console.WriteLine($"  Total number of grades: {counter}");
            Console.WriteLine($"  Class Average: {average:F}");
            Console.WriteLine();
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("  No valid grades were entered ");
        }

        }// end Main
}// end class ClassAverage
