// ForEachIntroduction.cs
// first use and look at the For Each statement for use with arrays
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachIntroduction
{
    class ForEachIntroduction
    {
        static void Main(string[] args)
        {
            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            foreach (int element in array)
            {
                total = total + element;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"  Total of all array elements is: {total}");
            Console.WriteLine();
            Console.WriteLine();
        }//end Main
    }//end class ForEachIntroduction
}// end Namespace
