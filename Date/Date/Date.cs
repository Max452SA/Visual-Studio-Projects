// Date.cs
// Dtate class declaration to demonstrate the use of Composition amongst classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    public class Date
    {
        private int month;      // months 1-12
        private int day;        // days 1-31 based in month
        public int Year { get; private set; }        // auto-implemented property year

        // Constructor: use property Month to confirm proper value for month;
        // use property Day to confirm the proper value for day
        public Date(int month, int day, int year)
        {
            Month = month;  // validates month
            Year = year;    // could validate year
            Day = day;      // validates day
            Console.WriteLine($"  Date object constructor for date {this}");
         }

        // property that gets and sets the month
        public int Month
        {
            get
            {
                return month;
            }
            private set     //make writing to the property inaccessible outside this class
            {
                if (value <= 0 || value > 12)   // validates the Month property
                {
                    Console.WriteLine();
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"  {nameof(Month)} must be 1-12");
                }

                month = value;
            }
        }

        // property that gets and sets the day value
        public int Day
        {
            get
            {
                return day;
            }
            private set     // make writing to this property inaccesible outside the class
            {
                int[] daysPerMonth =
                    {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

                // check if the day is in range for the month
                if (value <= 0 || value > daysPerMonth[Month])
                {
                    Console.WriteLine();
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"  {nameof(Day)} out of range for the " +
                        $"current month/year ");
                }

                // check if the current year is a Leap year
                if (Month == 2 && value == 29 && !(Year % 400 == 0 || (Year % 4 == 0 && Year % 100 == 0)))
                {
                    Console.WriteLine();
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"  {nameof(Day)} out of range for the " +
                        $"current month/year ");
                }
                day = value;
            }
        }

            // return a string of the form day/month/year 
            public override string ToString()
            {
                return ($"  {Day}/{Month}/{Year}");
            }

    }//end class Date
}//end namespace Date
