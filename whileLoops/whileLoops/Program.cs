using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("   How old are you? ");
            int age = int.Parse(Console.ReadLine());
            int counter = 0;

            while (age > 0)
            {
                counter++;
                Console.Write("  "+ counter.ToString() +". Happy Birthday ");
                age--;
            }
            Console.WriteLine("\n  Ta Da! ");
            Console.WriteLine();
        }
    }
}
