using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        public static void Main(String[] args)
        {

            bool flag = true;    //boolean flag value continues while loop while flag is true

            while (flag == true) 
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("  Pick a number between 1 and 5:  ");
                int choice = int.Parse(Console.ReadLine()); //integer choice stores the user choice
                // int.Parse(Console.ReadLine()); reads the user input and parses the integer value
                // to a string.

                Console.WriteLine();
                switch (choice)
                {
                    case 5:
                        {
                            Console.WriteLine("   You have picked the largest legal value ");
                            Console.WriteLine();
                            flag = false;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("   You picked 4 ");
                            Console.WriteLine();
                            flag = false;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("   You picked 3 ");
                            Console.WriteLine();
                            flag = false;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("   You picked 2 ");
                            Console.WriteLine();
                            flag = false;
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("   You picked the lowest legal value");
                            Console.WriteLine();
                            flag = false;
                            break;
                        }
                    default:
                        Console.WriteLine("   You have not chosen a legal value, please try again! ");
                        break;

                } //end switch statement

            } //end while loop
        }
    }
}
