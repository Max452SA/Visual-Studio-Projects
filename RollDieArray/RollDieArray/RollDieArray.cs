// RollDie.cs
// a more efficient way rolling a six sided die 60,000,000 times using an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDieArray
{
    class RollDieArray
    {
        static void Main(string[] args)
        {
            var randomNumbers = new Random();   //random number generator
            var frequency = new int[7];         // array frequency (counts frequency of each roll)
            
            for (var roll = 1; roll <= 60000000; roll++)
            {
                ++frequency[randomNumbers.Next(1, 7)];
            }

            Console.WriteLine();
            Console.WriteLine($"{"  Face"} {"Frequency",14} ");
            Console.WriteLine();

            for (var face = 1; face < frequency.Length; face++)
            {
                Console.WriteLine($"{face,5}{frequency[face],15}");
            }
            Console.WriteLine();
        }//end Main
    }//end class RollDieArray
}
