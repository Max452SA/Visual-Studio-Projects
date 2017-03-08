// StudentPoll.cs
// poll analysis app using arrays and exception handling
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPoll
{
    class StudentPoll
    {
        static void Main(string[] args)
        {
            //the student response array
            int[] responseArray = { 1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3, 2, 3, 3, 2, 14 };
            var frequency = new int[6];        //array of frequency counters

            //for each answer, select the responseArray element and use that value as a 
            //frequency index to determine which element to increment
            for (int count = 0; count < responseArray.Length; count++)
            {
                try
                {
                    ++frequency[responseArray[count]];
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"responseArray[{count}] = {responseArray[count]}\n");
                }
            }

            Console.WriteLine($"{"  Rating"}{"Frequency",13}");
            Console.WriteLine();

            for (int rating = 1; rating < frequency.Length; rating++)
            {
                Console.WriteLine($"{rating,6}{frequency[rating],11}");
            }
            Console.WriteLine();

        }//end Main
    }//end class StudentPoll
}
