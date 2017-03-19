// PassArray.cs
// program that demonstrates the passing of Arrays and individual Array elements to methods
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassArray
{
    class PassArray
    {
        static void Main(string[] args)
        {
            //method Main will create the array and calls methods ModifyArray and ModifyElement

            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(" Demonostration of " +
                "the effects of passing reference to the entire array: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" The Values of the original Array are: ");

            //foreach outputs the original array elements
            foreach (var value in array)
            {
                Console.Write($"  {value}");
            }

            ModifyArray(array);  //pass array reference
            Console.WriteLine("\n\n  The Values of the modified array are:");

            //output the modified array elements
            foreach (var value in array)
            {
                Console.Write($"  {value}");
            }

            Console.WriteLine();
            Console.WriteLine("\n\n  The Effects of passing array element value:\n" +
                $"  array[3] before method ModifyElement: {array[3]}");
            Console.WriteLine();

            ModifyElement(array[3]);    //attempt to modify array[3]
            Console.WriteLine($"  array[3] after method ModifyElement: {array[3]}");
            Console.WriteLine();

        }//end Main

        //method ModifyArray multiplies each element of an array by 2
        static void ModifyArray(int[] array2)
        {
            for (var count = 0; count < array2.Length; count++)
            {
                array2[count] *= 2;
            }
        }//end ModifyArray

        //method ModifyElement multiplies argument by 2
        static void ModifyElement(int element)
        {
            element *= 2;
            Console.WriteLine($"  Value of element in method ModifyElement: {element}");
        }

    }//end class PassArray
}//end namespace PassArray
