// InitArray.cs
// Creating (fig 8.2) and intializing an array of elements with default values
//1st branch (fig 8.3) then introduces an Initializer...
//2nd then (fig 8.4) stores a value in each of the arrays elements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitArray
{
    class InitArray
    {
        static void Main(string[] args)
        {

            //int[] array = new int[5];   //array with 5 integer elements initialized to 0

            //initializer list specifies the value of each of the Array's elements
            //int[] array = { 32, 27, 64, 18, 95 };

            const int ArrayLength = 5;
            int[] array = new int[ArrayLength];

            for(int counter = 0; counter < array.Length; counter++)
            {
                array[counter] = 2 + 2 * counter;
            }
        
            Console.WriteLine();
            Console.WriteLine($"  {"Index"} {"Value",8}");    //Output Headings
            Console.WriteLine($"  {"====="} {"=====",8}");
            
            for (int counter = 0; counter < array.Length; counter++)
            {
                Console.WriteLine($"{counter,5} {array[counter],8}"); //displays each elements value
            }
            Console.WriteLine();
        }//end Main

    }//end class InitArray
}//end Namespace
