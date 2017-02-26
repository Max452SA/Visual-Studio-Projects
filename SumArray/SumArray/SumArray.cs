// SumArray.cs
// simple program that totals the sum of the elements of an array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    class SumArray
    {
        static void Main(string[] args)
        {
            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            for (int count = 0; count < array.Length; count++)
            {
                total += array[count];
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"  Total of array elements is: {total}");
            Console.WriteLine();
            Console.WriteLine();
        }//end Main
    }//end class SumArray
}//end Namespace
