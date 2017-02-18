using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            // A simple text output assigning Hello World to the myString variable and output.
            // Then assigning the integer myFirstValue variable and adding it to the Real(double) valued
            // mySecondVariable and outputting the sum of the two (result is double) using the Console.WriteLine
            // command and the toString method.
            // @Author: Mridul Maharaj - 07/09/2016 ;3:45am
        
            var myString = " Hello World ";
            Console.WriteLine(myString);
            int myFirstValue = 23;
            double mySecondValue = 45.79;
            double sum = myFirstValue + mySecondValue;
            Console.WriteLine();
            Console.WriteLine(" myFirstValue = " + myFirstValue.ToString());
            Console.WriteLine(" mySecondValue = " + mySecondValue.ToString());
            Console.WriteLine(" The Sum of myFirstValue + mySecondValue is: " + sum.ToString());
        }
    }
}
