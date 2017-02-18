using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanValues
{
    class Program
    {
        // a simple program that manipulates variables of the type Boolean (bool)
        // boolean variables can only be either true or false and nothing else
        // @author - Mridul Maharaj - 2016/09/08 - 2h33am.

        public static void Main(String[] args)
        {
            Console.WriteLine();

            // first boolean variable with value true as 3+2 does equal 5
            bool myFirstBoolean = 3 + 2 == 5;
            Console.WriteLine("     myFirstBoolean Variable = " + myFirstBoolean.ToString());

            // 2nd boolean variable with value false as 3+2 is not greater than 5
            bool mySecondBoolean = 3 + 2 > 5;
            Console.WriteLine("     mySecondBoolean Variable = " + mySecondBoolean.ToString());

            // 3rd boolean variable with value false as both arguments are not true. 
            // mySecondBoolean returns value of false - when using && both arguments have to be true.
            // ensure that you're REALLY careful with boolean logic! 
            bool bothAreTrue = myFirstBoolean && mySecondBoolean;
            Console.WriteLine("     bothAreTrue evaluates/returns a value of: " + bothAreTrue);
            Console.WriteLine();

            // 4th boolean variable - oneIsTrue - using the OR || argument
            // returns a value of true, as one of the arguments being compared is true
            bool oneIsTrue = myFirstBoolean || mySecondBoolean;
            Console.WriteLine("     oneIsTrue evaluates/returns a value of {0} as one expression is {0}: ", oneIsTrue);
            Console.WriteLine();
        }
    }
}
