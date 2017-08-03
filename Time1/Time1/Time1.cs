// Time1.cs
// Time1 class declaration that maintains the time in universal 24 hour format
using System;       // the System namespace contains the ArgumentOutOfRangeException
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time1
{
    public class Time1
    {
        public int Hour { get; set; }      // Hours 0 - 23
        public int Minute { get; set; }    // minutes 0 - 59
        public int Second { get; set; }    // seconds 0 - 59

        // set a new time value using universal time; and throw an exception 
        // if the hour, minute or second value is invalid
        public void SetTime(int hour, int minute, int second)
        {
            if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59) || 
               (second < 0 || second > 59))
            {
                throw new ArgumentOutOfRangeException();
            }

            Hour = hour;
            Minute = minute;
            Second = second;
        }

        // convert to string in Universal Time Format (HH:MM:SS)
        public string ToUniversalString() =>
            $"  {Hour:D2}:{Minute:D2}:{Second:D2}";

        // convert to string in Standard Time format (H:MM:SS AM or PM)
        public override string ToString()
        {
            return $"  {((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
                   $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";
        }

        // public method that returns the time as number of seconds since midnight
        public int SecondsSinceMidnight()
        {
            // The number of seconds can be calculated as hours after midnight * 60 seconds
            // plus the number of minutes after the hour * 60 seconds plus the 
            // number of seconds elapsed after the last minute 
            int Sum = (Hour * 60) + (Minute * 60) + Second;
            return Sum;
        }
    }// end class Time1
}// end namespace 
