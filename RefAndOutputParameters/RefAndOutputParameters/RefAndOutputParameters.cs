// RefAndoutputParameters.cs
// Use and examples of Reference, Output and Value parameters in C# 6.0 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutputParameters
{
    class RefAndOutputParameters
    {
        static void Main(string[] args)
        {
            int y = 5;  //variable is declared and initialized
            int z;      //variable is declared but not initialized with any value

            //Displays the original values of y and z
            Console.WriteLine();
            Console.WriteLine($"  Original value of variable y: {y}");
            Console.WriteLine($"  Original value of variable z: Uninitialized\n");

            //pass y and z by reference
            SquareRef(ref y);
            SquareOut(out z);

            //Display values of y and z after they are modified by the methods
            //SquareRef, SquareOut 
            Console.WriteLine($"  Value of y after SquareRef: {y}");
            Console.WriteLine($"  Value of z after SquareOut: {z}\n");

            //Now pass y and z by value
            Square(y);
            Square(z);

            //Display values of y and z after they are passed to method Square 
            //demonstrates that areguments passed by value are not modified but copies made
            Console.WriteLine($"  Value of y after Square: {y}");
            Console.WriteLine($"  Value of z after Square: {z}");
            Console.WriteLine();
            Console.WriteLine();
        }//end Main

        //method uses reference parameter x to modify caller's variable
        static void SquareRef(ref int x)
        {
            x = x * x;
        }

        //method uses output parameter x to assign a value to uninitialized variable
        static void SquareOut(out int x)
        {
            x = 6;      //assigns a value to the callers variable
            x = x * x; 
        }

        //method where parameter x receives a copy of the value passed as an argument
        //so this method cannot modify the caller's variable
        static void Square(int x)
        {
            x = x * x;
        }
    }//end class RefAndOutputParameters
}
