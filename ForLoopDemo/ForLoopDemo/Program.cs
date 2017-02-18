using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopDemo
{
    class Program
    {
        public static void Main(string[]args)
        {
            //A simple example program running a for loop with fomrat - for( initialzation; test; increment)

            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"  Hello {i.ToString()} ");
            }
        }
    }
}
