// MethodOverload.cs
// Overloading method declarations
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class MethodOverload
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"  Square of Integer 7 is : {Square(7)}");
            Console.WriteLine($"  Square of double 7.5 is : {Square(7.5)}");
            Console.WriteLine();
            Console.WriteLine();
        }// end Main

        static int Square(int intValue)
        {
            Console.WriteLine($"  Called square with int argument: {intValue}");
            return (intValue * intValue);
        }// end static int Square

        static double Square(double doubleValue)
        {
            Console.WriteLine($"  Called square with double argument: {doubleValue}");
            return (doubleValue * doubleValue);
        }// end static double Square

    }// end class MethodOverload
}
