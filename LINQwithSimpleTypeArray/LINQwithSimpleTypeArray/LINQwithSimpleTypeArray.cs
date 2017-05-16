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
        public static void Main(string[] args)
        {
            var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            //display original values in the array
            Console.WriteLine();
            Console.Write("  Original Array: ");
            foreach (var element in values)
            {
                Console.Write($" {element}");
            }

            var filtered =
                from value in values    //data source is array values
                where value > 4
                select value;

            Console.Write("\n  Array values greater than 4: ");
            foreach (var element in filtered)
            {
                Console.Write($"  {element}");
            }

            //orderby clause to sort original values in ascending order
            var sorted = 
                from value in values
                orderby value
                select value;

            Console.Write("\n  Original Array, sorted: ");
            foreach (var element in sorted)
            {
                Console.Write($"  {element}");
            }

            //sort the filtered results in descending order
            var sortFilteredResults =
                from value in filtered      //data source is LINQ query filtered
                orderby value descending
                select value;

            Console.Write("\n  Values greater than 4, descending order from two queries: ");
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

            //display both the filtered and sorted results
            Console.Write("\n  Values greater than 4 and ordered in descending order:  ");
            foreach (var element in sortAndFilter)
            {
                Console.Write($"  {element}");
            }

            Console.WriteLine();
            Console.WriteLine();
        }//end Main
    }//end class
}//end namespace SimpleTypeArray
