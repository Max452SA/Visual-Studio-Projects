// InitArray.cs
// using command line arguments to intialize an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitArrayMain
{
    class InitArray
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine();
                Console.WriteLine("  Error: Please re-enter the entire command, including \n" +
                                  "  an array size, initial value and increment size.");
            }
            else
            {
                //get the array size from the 1st command line argument
                var arrayLength = int.Parse(args[0]);
                var array = new int[arrayLength];

                var initialValue = int.Parse(args[1]);
                var increment = int.Parse(args[2]);

                //calculate the value for each array element
                for (var count = 0; count < array.Length; ++count)
                {
                    array[count] = initialValue + increment * count;
                }

                Console.WriteLine($"  {"Index"}{"Value",8}");

                //display the array index and values
                for (var count = 0; count < array.Length; ++count)
                {
                    Console.WriteLine($"  {count,5}{array[count],8}");
                }
            }
        }
    }
}
