using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsDemo
{
    class Program
    {
        enum Ages
        {
            oldEnough = 5,
            canDrink = 21,
            tooOld = 90,
        }

        public static void Main(string[] args)
        {
            const int Age = 20;

            if (Age < (int)Ages.oldEnough)
            {
                Console.WriteLine();
                Console.WriteLine("  Sorry, you are too young to play ");
                Console.WriteLine();
            }
            else if (Age < (int)Ages.canDrink)
            {
                Console.WriteLine();
                Console.WriteLine("  You are old enough to play but you cannot Drink! ");
                Console.WriteLine();
            }
            else if (Age < (int)Ages.tooOld )
            {
                Console.WriteLine();
                Console.WriteLine("  Have Fun ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("  How about a nice nap? ");
                Console.WriteLine();
            }

       }
    }
}
