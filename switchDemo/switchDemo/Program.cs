using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchDemo
{
    class Program
    {
        enum Movies
        {
            Casablanca,
            Godfather,
            Matrix,
        }
        
        public static void Main(String[]args)
        {
            Movies bestMovie = Movies.Godfather;

            switch (bestMovie)
            {
                case Movies.Casablanca:
                    Console.WriteLine();
                    Console.WriteLine("  Ahhh, Bogie and Bacall...");
                    break;
                case Movies.Godfather:
                    Console.WriteLine();
                    Console.WriteLine("  I'll make him an offer...");
                    break;
                case Movies.Matrix:
                    Console.WriteLine();
                    Console.WriteLine("  Will you take the Blue pill or the Red pill? ");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("  You have to pick one choice... ");
                    break;
            }
        }
    }
}
