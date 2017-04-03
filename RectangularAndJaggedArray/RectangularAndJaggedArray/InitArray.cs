// initArray.cs
// Initializing Rectangular and Jagged Arrays
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularAndJaggedArray
{
    class InitArray
    {
        //Main method creates and outputs rectangular and jagged arrays
        static void Main(string[] args)
        {
            //for rectangular arrays, every row HAS to be the same length
            int[,] rectangular = { { 1, 2, 3 }, { 4, 5, 6 } };

            //with jagged arrays, initialize a new int[] for every row
            //and we know that eery row doesn't have to be the same length
            int[][] jagged = {new int[] {1,2},
                              new int[] {3},
                              new int[] {4,5,6} };

            OutputArray(rectangular);       //displays the rectangular array by row
            Console.WriteLine();
            OutputArray(jagged);            //displays the jagged array by row

        }//end Main

        //method OutputArray outputs rows and columns of a rectangular array
        static void OutputArray(int[,] array)
        {
            Console.WriteLine("  The values in the rectangular array by row are: ");

            //loop through rows first
            for(var row = 0; row < array.GetLength(0); ++row)
            {
                //loop through columns of a current row
                for(var column = 0; column < array.GetLength(1); ++column)
                {
                    Console.Write($"  {array[row,column]} ");
                }
                Console.WriteLine();        //starts a new line of output
            }
        }

        //method OutputArray outputs rows and columns of a jagged array
        static void OutputArray(int[][] array)
        {
            Console.WriteLine("  The values in the jagged array by row are:  ");

            //loop through each row
            foreach (var row in array)
            {
                //loop through each element in the current row
                foreach (var element in row)
                {
                    Console.Write($"  {element} ");
                }
                Console.WriteLine();        //starts a new line of output
            }
        }//end method OutputArray

    }//end class InitArray
}
