using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class TemperatureConverter
    {
        //method CelsiusToFahrenheit converts a value from Degrees Celsius to Degrees Fahrenheit
        public static double CelsiusToFahrenheit(string tempCelsius)
        {
            double celsius = Double.Parse(tempCelsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }


        //method FahrenheitToCelsius converts a value from Degrees Fahrenheit to Celsius
        public static double FahrenheitToCelsius(string tempFahrenheit)
        {
            double fahrenheit = Double.Parse(tempFahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

    }
}
