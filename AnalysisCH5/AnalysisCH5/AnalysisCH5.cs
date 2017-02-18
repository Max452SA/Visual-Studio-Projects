// fig 5.9: Analysis.cs
// Analysis of examination results, using nested control statements
using System;

public class Analysis
{
    public static void Main()
    {
        int counter = 0;
        int numPassed = 0; //counter for number of students who passed
        int numFailed = 0; //counter for number of students who failed

        Console.WriteLine();
        Console.WriteLine();
        while (counter < 10)
        {
            
            Console.Write("  Please enter result (1 = pass) or (2 = fail): ");
            int result = int.Parse(Console.ReadLine());
            if (result ==1)
            {
                numPassed += 1;
            }
            else if (result ==2)
            {
                numFailed += 1;
            }
            else
            {
                counter--;
                Console.WriteLine();
                Console.WriteLine("  \t\t INVALID INPUT!!!");
            }
            counter++;

        }// end while

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"  No. of Passes: {numPassed}");
        Console.WriteLine($"  No. of Failures: {numFailed}");
        if (numPassed > 8)
        {
            Console.WriteLine();
            Console.WriteLine(" Bonus to the instructor as more than 8 students passed! ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
