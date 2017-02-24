// FactorialTest.cs
// Recursive Factorial Method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTest
{
    class FactorialTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("  Factorials 1 - 10 ");
            //Main method will calculate the factorials from 0 to 10
            for (long counter = 0; counter <= 10; counter++)
            {
                Console.WriteLine($" \t{counter}! = {Factorial(counter)}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        //static method Factorial
        //test for and calculation of Factorials via Recursion
        static long Factorial(long num)
        {
            //base test case
            if (num <= 1)
            {
                return 1;
            }
            else //recursion
            {
                return (num * Factorial(num - 1));
            }
        }//end Method Factorial

    }//end class FactorialTest
}//end Namespace FactorialTest
