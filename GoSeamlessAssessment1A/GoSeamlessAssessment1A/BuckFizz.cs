//class BuckFizz.cs
//a simple class that instantiates a string array object buckFizzArray with 100 elements
//going from 1 - 100, it prints the numbers from 1 to 100 int a table, 
//but, when a number is divisible by 3, Buck is printed, when a number is divisible by 5,
//then Fizz is printed, and when a number is divisible by both 3 and 5, then the word 
//BuckFizz is printed instead.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSeamlessAssessment
{
    class BuckFizz
    {
        static void Main(string[] args)
        {
            //create a new string Array object named buckFizzArray with 100 elements
            string[] buckFizzArray = new string[100];

            //initialize an integer variable numElements to keep count of the 
            //number of elements in the array from 1 - 100, allows the loop counter and
            //array element counter to stay seperate entities, easing calculations
            int numElements = 1;

            int buckCount = 0;          //integer variable for no. of 'buck' elements
            int fizzCount = 0;          //integer variable for no. of 'fizz' elements
            int buckFizzCount = 0;      //integer variable for no. of 'buckfizz' elements
            int inDivisble = 0;         //integer variable for no. elements not divisible by 3 and/or 5.

            //for loop to run through elements of the array
            for (int count = 0; count < buckFizzArray.Length; count++)
            {
                //test if the element number is divisible by 3 and by 5 then print BuckFizz
                if ((numElements % 3 == 0) && (numElements % 5 == 0))
                {
                    buckFizzArray[count] = "BuckFizz";
                    buckFizzCount++;
                }

                //test if the element number is divisible only by 3 then print Buck
                else if (numElements % 3 == 0)
                {
                    buckFizzArray[count] = "Buck";
                    buckCount++;
                }

                //test if the element number is divisible only by 5 then print Fizz
                else if (numElements % 5 == 0)
                {
                    buckFizzArray[count] = "Fizz";
                    fizzCount++;
                }

                //if the element number is not divisble by 3, and/or 5, it just inserts  
                //the element number to that element of the array
                else
                {
                    buckFizzArray[count] = ("      " + (numElements));
                    inDivisble++;
                }

                numElements++;
            }//end for

            //variable numElements will be incremented to 101, as it was initialized to 1
            //so decrement numElements by 1 to bring it to exactly 100 elements
            numElements--;

            Console.WriteLine();
            Console.WriteLine();

            //Headers for the display of the Array - buzzFizzArray
            //string interpolation used to neaten display values
            Console.WriteLine($" {"Index",10}{"Array Value",20}");
            Console.WriteLine($" {"=====",10}{"===========",20}");
            Console.WriteLine();

            for (int count = 0; count < buckFizzArray.Length; count++)
            {
                //for loop allows display of each element of the array
                Console.WriteLine($" {count + 1,8}{buckFizzArray[count],17}");
            }

            Console.WriteLine();
            //Total number of elements in the array are displayed to ensure correct 
            //number of calculations and elements present in the array
            Console.WriteLine($"  Total number of elements in array: {numElements,19}");
            Console.WriteLine($"  No. of elements indivisble by 3 and/or 5: {inDivisble,11}");
            Console.WriteLine($"  No. of elements divisble by 3 (BUZZ): {buckCount,15}");
            Console.WriteLine($"  No. of elements divisble by 5 (FIZZ): {fizzCount,15}");
            Console.WriteLine($"  No. of elements divisble by 3 and 5 (BUCKFIZZ): {buckFizzCount,4}");
            Console.WriteLine();
            Console.WriteLine();

        }//end Main 

    }// end class BuckFizz
}// end namespace GoSeamlessAssessment