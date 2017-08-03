// Time1Test.cs
// Time1 object used in the app
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time1
{
    class Time1Test
    {
        public static void Main(string[] args)
        {
            // first create & initialize a new Time1 object
            var time = new Time1();     // this will invoke the Time1 Constructor

            // output string representations of the time
            Console.WriteLine();
            Console.WriteLine($"  The initial Universal Time is: {time.ToUniversalString()}");
            Console.WriteLine($"  The initial Standard Time is:  {time.ToString()}");
            Console.WriteLine();    // outputs a blank line

            // change the time and then output the updated time
            time.SetTime(13, 27, 6);
            Console.WriteLine($"  Universal time after SetTime is: {time.ToUniversalString()}");
            Console.WriteLine($"  Standard time after SetTime is:  {time.ToString()}");
            Console.WriteLine();    // output a blank line again

            // attempt to set the time with invalid values and catch the thrown exception
            try
            {
                time.SetTime(99, 99, 99);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n ");
            }

            // now finally display the time after the attempt to set an invalid time
            Console.WriteLine("  After attempting invalid settings: ");
            Console.WriteLine($"  Universal time: {time.ToUniversalString()}");
            Console.WriteLine($"  Standard time:  {time.ToString()}");
            Console.WriteLine($"  The total Number of Seconds elapsed since midnight: " +
                            $"{time.SecondsSinceMidnight()}");
            Console.WriteLine();

        }// end Main method
    }// end class Time1Test
}// end namespace
