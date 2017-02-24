// RandomIntegers.cs
// Generating Random numbers using the Shift and Scale fucntionality of the Random Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomIntegers
{
    class RandomIntegers
    {
        static void Main(string []args)
        {
            //instantiate a new Random number generator object
            Random randomNumbers = new Random();

            for (int count = 1; count <= 20; count++)
            {
                //picks a random integer from 1-6 from the 1st arguments value up to but
                //not including the 2nd arguments value
                int face = randomNumbers.Next(1, 7);
                Console.Write($" {face} ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }// end Main

    }// end class RandomIntegers
}// end Namespace RandomIntegers
