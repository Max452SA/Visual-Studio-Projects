using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedConstants
{
    class Program
    {
        enum Colour
        {
           Red,
           Orange,
           Yellow,
           Green,
           Blue,
           Indigo,
           Violet,
        }
        public static void Main(String [] args)
        {

           /* bool flag = true;

            while (flag == true)  //while flag is true the loop will continue to run (invalid colour entered)
            {
                Console.WriteLine();
                Console.WriteLine("  Colours of the Rainbow: ");
                Console.WriteLine("  Red, Orange, Yellow, Green, Blue, Indigo, Violet...");
                Console.WriteLine("  Please enter your favourite colour of the Rainbow: ");
                string tempColour = Console.ReadLine();

                /*if (tempColour.Equals(Colour.Red.ToString()))
                {
                    Colour favourite = Colour.Red;
                }
                else if (tempColour.Equals(Colour.Orange.ToString()))
                {
                    Colour favourite = Colour.Orange;
                }
                else if (tempColour.Equals(Colour.Yellow.ToString()))
                {
                    Colour favourite = Colour.Yellow;
                }
                else if (tempColour.Equals(Colour.Green.ToString()))
                {
                    Colour favourite = Colour.Green;
                }
                else if (tempColour.Equals(Colour.Blue.ToString()))
                {
                    Colour favourite = Colour.Blue;
                }
                else if (tempColour.Equals(Colour.Indigo.ToString()))
                {
                    Colour favourite = Colour.Indigo;
                }
                else if (tempColour.Equals(Colour.Violet.ToString()))
                {
                    Colour favourite = Colour.Violet;
                } */

                Colour favourite = Colour.Blue; 

                switch (favourite)
                {
                    case (Colour.Red):
                        Console.WriteLine("  You chose Red ");
                        Console.WriteLine();
                        break;
                    case (Colour.Orange):
                        Console.WriteLine("  You chose Orange ");
                        Console.WriteLine();
                    
                        break;
                    case (Colour.Yellow):
                        Console.WriteLine("  You chose Yellow ");
                        Console.WriteLine();
                        break;
                    case (Colour.Blue):
                        Console.WriteLine("  You chose Blue ");
                        Console.WriteLine();
                        break;
                    case (Colour.Indigo):
                        Console.WriteLine("   You chose Indigo");
                        Console.WriteLine();
                        break;
                    case (Colour.Violet):
                        Console.WriteLine("  You chose Violet ");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("   You did not choose a colour? Please try again...");
                        break;
                }
            }
        }
    }
