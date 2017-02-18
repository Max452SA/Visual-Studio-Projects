using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
    class Program
    {
        public static void Main(String[]args)
        {
            //Variable Initialization 
            int myAge = 21;     //integer variable myAge
            int x = 5;          //integer variable x with value of 5
            double myHourlyRate = 150.00;        //double floating point value (decimal points) with value = 150.00
            var myName = "Mridul Maharaj";

            Console.WriteLine();
            Console.WriteLine($"  My Age: {myAge},  x: {x},  My Hourly Rate: {myHourlyRate},  My Name: {myName} ");

            //changing the values of the same variable used above (No need for initialization, types have been assigned already)
            myAge = 35;
            x = 20;
            myHourlyRate = 85.00;
            myName = "George Washington";

            Console.WriteLine();
            Console.WriteLine($"  My Age: {myAge},   x: {x},   My Hourly Rate: {myHourlyRate},   My Name: {myName}");

        }
    }
}
