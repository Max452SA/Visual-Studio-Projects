using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementV2
{
    class Program
    {
        public static void Main(string[]args)
        {
            int choice = 0;
            bool flag = false;
            Console.WriteLine();
            while (flag == false)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("   Please enter a number from 1 to 5:  ");
                choice = int.Parse(Console.ReadLine());
                // the line above assigns the user input to an integer variable called choice
                // the int.Parse from the Console.Readline statement converts string input value to int

                switch (choice)
                {
                    case 6:
                    case 5:
                        Console.WriteLine("  You picked the largest legal value! ");
                        Console.WriteLine();
                        flag = true;
                        break;
                    case 4:
                        Console.WriteLine("  You picked 4 ");
                        Console.WriteLine();
                        flag = true;
                        break;
                    case 3:
                        Console.WriteLine("  You picked 3 ");
                        Console.WriteLine();
                        flag = true;
                        break;
                    case 2:
                        Console.WriteLine("  You picked 2 ");
                        Console.WriteLine();
                        flag = true;
                        break;
                    case 1:
                        Console.WriteLine("  You picked the lowest legal value! ");
                        Console.WriteLine();
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("  Not a legal entry! Please try again: ");
                        break;
                }
            }
        }
    }
}
