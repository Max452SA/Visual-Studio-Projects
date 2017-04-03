// ArrayReferenceTest.cs
// example of Passing array references by value and by reference
// and testing their effects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReferenceTest
{
    class ArrayReferenceTest
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3 };     //creates and initializes variable firstArray

            int[] firstArrayCopy = firstArray;

            Console.WriteLine();
            Console.WriteLine("  Test passing firstArray reference by value ");
            Console.Write("  Contents of firstArray before calling method FirstDouble:\n\t");

            foreach (var element in firstArray) //displays the contents of firstArray
            {
                Console.Write($"  {element}  ");
            }

            //pass variable firstArray by value to FirstDouble
            FirstDouble(firstArray);

            Console.Write("\n  Contents of firstArray after calling method FirstDouble:\n\t");

            foreach (var element in firstArray) //display the contents of firstArray
            {
                Console.Write($"  {element}  ");
            }

            //now test whether reference was changed by FirstDouble
            if (firstArray == firstArrayCopy)
            {
                Console.WriteLine();
                Console.WriteLine("  The references refer to the same array ");
            }
            else
            {
                Console.WriteLine("\n\n  The references refer to different arrays ");
            }

            int[] secondArray = { 1, 2, 3 };        //creates and initiailizes variable SecondArray

            int[] secondArrayCopy = secondArray;

            Console.WriteLine("\n  Test passing secondArray reference by reference");
            Console.Write("  Contents of secondArray before calling method SecondDouble:\n\t");

            //display contents of secondArray before the method call
            foreach (var element in secondArray)
            {
                Console.Write($"  {element}  ");
            }

            //pass variable secondArray by reference to SecondDouble
            SecondDouble(ref secondArray);

            Console.Write("\n  The contents of secondArray after calling SecondDouble:\n\t");

            foreach (var element in secondArray) //display the contents of secondArray after method call 
            {
                Console.Write($"  {element}  ");
            }

            //test if reference was changed by method SecondDouble
            if (secondArray == secondArrayCopy)
            {
                Console.WriteLine("\n\n  The references refer to the same array");
            }
            else
            {
                Console.WriteLine("\n\n  The references refer to different arrays");
            }
        }//end Main

        static void FirstDouble(int[] array)    //modify elements of array and attempt to modify reference
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] *= 2;      //double each elements value
            }

            //create a new array object and assign it's reference to array
            array = new int[] { 11, 12, 13 };
        }

        //modify elements of array and change reference array
        //to refer to a new array
        static void SecondDouble(ref int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] *= 2;      //double each elements value
            }

            //create a new array object and assign it's reference to array
            array = new int[] { 11, 12, 13 };
        }
    }
}
