using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[]args)
        {
            string selection = string.Empty;
            while (selection != "q" && selection != "Q")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("  Please enter C)elsius to Fahrenheit conversion or F)ahrenheit to Celsius conversion or Q)uit: ");
                selection = Console.ReadLine();
                double fahrenheit = 0, celsius = 0;

                switch(selection)
                {
                    case "C":
                    case "c":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(" Please enter the temperature in Degrees Celsius: ");
                        fahrenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($" Temperature in Fahrenheit:  {fahrenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(" Please enter the temperature in Degrees Fahrenheit: ");
                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($" Temperature in Celsius:  {celsius:f2}");
                        break;
                    case "Q":
                    case "q":
                        break;
                    default:
                        Console.WriteLine(" Invalid input. Please try again! ");
                        break;
                }
            }
        }
    }
}
