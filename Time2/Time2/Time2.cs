// Time2.cs 
//Time2 class declaration demonstrating overloaded constructors
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time2
{
    public class Time2 
    {
        private int hour;       // 0-23
        private int minute;     // 0-59
        private int second;     // 0-59

        //Constructor Time2 can be called with zero, one, two or three arguments
        public Time2(int hour = 0, int minute = 0, int second = 0)
        {
            setTime(hour, minute, second);  //invokes Method setTime to validate the time
        }

        //Time2 Constructor with another Time2 object supplied as an argument
        public Time2(Time2 time)
        : this(time.Hour, time.minute, time.Second) { }

        // set a new time value using Universal time; invalid values
        // cause the properties set accessors to throw exceptions
        public void setTime(int hour, int minute, int second)
        {
            Hour = hour;        //sets the Hour property with passed argument
            Minute = minute;    //sets the Minute property
            Second = second;    //sets the Second property
        }

        //Property that gets and sets the hour
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Hour)} must be within 0-23");
                }
                hour = value;
            }
        }

        //Property that gets and sets the Minute value
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Minute)} must be within 0-59");
                }
                minute = value;
            }
        }

        //Property that gets and sets the Second value
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Second)} must be within 0-59");
                }
                second = value;
            }
        }

        // Convert the string to universal time format (HH:MM:SS)
        public string ToUniversalString() =>
            $"  {Hour:D2}:{Minute:D2}:{Second:D2} ";

        // convert the string to standard time format (H:MM:SS AM of PM)
        public override string ToString()
        {
            return ($"  {((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
            $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}");
        }
    }// end Class Time2
}// end namespace
