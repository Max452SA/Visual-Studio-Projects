// MaximumFinder.cs
// simple class with a Maximum method displaying usage of three parameters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumFinder
{
    class MaximumFinder
    {
        static void Main(string []args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  Please enter the 1st Floating point value: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("  Please enter the 2nd Floating point value: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("  Please enter the 3rd Floating point value: ");
            double num3 = double.Parse(Console.ReadLine());

            //stores the Maximum value in variable result after calling Method Maximum
            //to determine the largest amongst the three paramters passed in 
            double result = Maximum(num1, num2, num3);

            Console.WriteLine();
            Console.WriteLine("  The Maximum value is: " + result);
            Console.WriteLine();

        }// end Main

        static double Maximum(double x, double y, double z)
        {
            //    double maximumValue = x;

            //    if (y > maximumValue)
            //    {
            //        maximumValue = y;
            //    }

            //    if (z > maximumValue)
            //    {
            //        maximumValue = z;
            //    }

            // implementation of the same method using Math class and Math.Max static method
            double tempYZ = Math.Max(y, z);
            double maximumValue = Math.Max(x,tempYZ);

            return maximumValue;
        }// end method Maximum

    }// end Main
}// end Namespace MaximumFinder 
