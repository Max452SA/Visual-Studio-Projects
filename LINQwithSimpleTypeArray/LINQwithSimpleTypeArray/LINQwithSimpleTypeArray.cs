// LINQwithSimpleTypeArray.cs
// 1st example of using LINQ to Objects using an integer array 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQwithSimpleTypeArray
{
    class LINQwithSimpleTypeArray
    {
        static void Main(string[] args)
        {
            var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("  Original Array: ");
            foreach (var element in values)     //displays the original array
            {
                Console.Write($"  {element}");
            }

            //LINQ query that obtains all values greater than 4 from the array
            var filtered =
                from value in values
                where value > 4
                select value;

            Console.Write("\n  Array values greater than 4: "); //displays the filtered results
            foreach (var element in filtered)
            {
                Console.Write($"  {element}");
            }

            //sort values in ascending order using the orderby clause
            var sorted =
                from value in values
                orderby value
                select value;

            Console.Write("\n  Original Array, Sorted: ");
            foreach (var element in sorted)
            {
                Console.Write($"  {element}");
            }

            //sort the filtered results in descending order
            var sortFilteredResults =
                from value in filtered
                orderby value descending
                select value;

            Console.Write("\n  Values greater than 4 in descending order (two queries):");
            foreach (var element in sortFilteredResults)
            {
                Console.Write($"  {element}");
            }

            //filter original array and sort in descending order
            var sortAndFilter =
                from value in values
                where value > 4
                orderby value descending
                select value;

            Console.Write("\n  Values greater than 4, descending order (one query):");
            foreach (var element in sortAndFilter)
            {
                Console.Write($"  {element}");
            }

            Console.WriteLine();
            Console.WriteLine();

        }//end Main
    }
}
