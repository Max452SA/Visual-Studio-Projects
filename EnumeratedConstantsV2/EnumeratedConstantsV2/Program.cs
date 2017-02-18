using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedConstantsV2
{
    class Program
    {
        enum Colour
        {  
            //enumerated list for the colour spectrum of the rainbow
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet,
        }

        public static void Main(String[]args)
        {
            //example program using enumerated constants

            Colour Favourite = Colour.Blue;

            switch (Favourite)
            {
                case Colour.Red:
                    Console.WriteLine();
                    Console.WriteLine("  You chose Red ");
                    break;
                case Colour.Orange:
                    Console.WriteLine();
                    Console.WriteLine("  You chose Orange ");
                    break;
                case Colour.Yellow:
                    Console.WriteLine();
                    Console.WriteLine("  You chose Yellow ");
                    break;
                case Colour.Green:
                    Console.WriteLine();
                    Console.WriteLine("  You chose Green ");
                    break;
                case Colour.Blue:
                    Console.WriteLine();
                    Console.WriteLine("  You chose Blue ");
                    break;
                case Colour.Indigo:
                    Console.WriteLine();
                    Console.WriteLine("  You chose Indigo ");
                    break;
                case Colour.Violet:
                    Console.WriteLine();
                    Console.WriteLine("  You chose Violet ");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("  You did not choose a colour??? ");
                    break;
            }

        }
    }
}
