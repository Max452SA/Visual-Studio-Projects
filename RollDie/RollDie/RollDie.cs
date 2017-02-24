// RollDie.cs
// rolls a six sided die 60 000 000 times and keeps track of the frequency of each number landed

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDie
{
    class RollDie
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();    //new random number generator object

            // variables that count the frequency of each number rolled
            int countFrequency1 = 0;
            int countFrequency2 = 0;
            int countFrequency3 = 0;
            int countFrequency4 = 0;
            int countFrequency5 = 0;
            int countFrequency6 = 0;

            for (int count=1; count <= 60000000; count++)
            {
                int face = randomNumbers.Next(1, 7);

                switch (face)
                {
                    case 1:
                        countFrequency1++;
                        break;
                    case 2:
                        countFrequency2++;
                        break;
                    case 3:
                        countFrequency3++;
                        break;
                    case 4:
                        countFrequency4++;
                        break;
                    case 5:
                        countFrequency5++;
                        break;
                    case 6:
                        countFrequency6++;
                        break;
                }//end switch
            }//end for

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Face\tFrequency");
            Console.WriteLine($"  1\t{countFrequency1}");
            Console.WriteLine($"  2\t{countFrequency2}");
            Console.WriteLine($"  3\t{countFrequency3}");
            Console.WriteLine($"  4\t{countFrequency4}");
            Console.WriteLine($"  5\t{countFrequency5}");
            Console.WriteLine($"  6\t{countFrequency6}");
            Console.WriteLine();
            Console.WriteLine();
        }//end Main
    }//end class RollDie
}//end Namespace RollDie
