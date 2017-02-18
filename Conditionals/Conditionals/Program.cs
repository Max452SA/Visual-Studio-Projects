using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        public static void Main(String []args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  What is your age? ");
            string ageAsString = Console.ReadLine(); //inputs age as type string using ReadLine
            int age = int.Parse(ageAsString); //parsing the integer class converts the string to an integer

            // we then use a conditional if statement to run simple conditional tests 
            //the if statement tests if the user is over the age of 21
            //if true, it prints you are an adult, if false, it moves into the else statement and 
            // prints that the user is not an adult yet...
            
            if (age >65)
            {
                Console.WriteLine("  You are a Senior Citizen ");
                Console.WriteLine();
            }
            else if (age >= 21)
            {
             
                Console.WriteLine("  You are an adult ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("  You are not yet a legal adult ");
                Console.WriteLine();
            }
        }
    }
}
