using System;

namespace ForLoops
{
    class Program
    {
        public static void Main(String [] args)
        {
            /* a simple for loop with initialization, test, and increment/decrement
               initializes a counter variable i for age of type integer = 0, 
               and tests if age < 10, runs the loop and then increments counter i

               - N.B. i is the universal counter variable used with for and for do loops in
                 object oriented languages such as C#, C++, and Java.  */

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" Happy Birthday!");
                // Happy Birthday is printed on a console window as long
                // as age is greater than 0
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   TaDa!!! ");
            Console.WriteLine();

            // for loops part 2 - more difficult and advanced implementation of the for loop
            // initialization and increment of the counter variable can happen outside the loop.

            for (int i=0; i <= 2000; i++)
            {
                if ( i % 100 == 0)  //The modulus argument 
                {
                    // % == modulus == returns the remainder of a division argument
                    // e.g. if the remainder for i divided by 100 = 0 then print happy birthday
                    // i.e. Happy Birthday will be printed every 100 times while i = 2000
                    Console.WriteLine();
                    Console.WriteLine("   Happy Birthday!  {0}", i);
                }
            }
            Console.WriteLine();
        }
    }
}
