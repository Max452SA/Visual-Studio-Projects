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
            Console.WriteLine();
            Console.WriteLine();
            //create a new integer array
            var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            Console.Write("  Original Array: ");
            foreach (var element in values)
            {
                Console.Write($" {element}");
            }

            //LINQ query that obtains all values greater than 4 from the array
            var filtered = 
                from value in values        //data source is values
                where value > 4
                select value;

            Console.Write("\n  Array values greater than 4:");
            foreach (var element in filtered)
            {
                Console.Write($" {element}");
            }

            //use the OrderBy clause to sort the original values in ascending order
            var sorted =
                from value in values        //data source is values
                orderby value
                select value;

            Console.Write("\n  Array with Original values sorted in Ascending Order: ");
            foreach(var element in sorted)
            {
                Console.Write($" {element}");
            }

            //sort the filtered results in descending order
            var sortFilteredResults =
                from value in filtered         //data source is filtered
                orderby value descending
                select value;

            Console.Write("\n  Values greater than 4, desecending order using two queries: ");
            foreach(var element in sortFilteredResults)
            {
                Console.Write($" {element}");
            }

            //filter the original array and sort results in descending order
            var sortAndFilter = 
                from value in values        //data source is values
                where value > 4 
                orderby value descending
                select value;

            Console.Write("\n  Values greater than 4, descending order using only one query ");
            foreach(var element in sortAndFilter)
            {
                Console.Write($" {element}");
            }

            Console.WriteLine();
            Console.WriteLine();
        }//end Main
    }//end class
}//end namespace SimpleTypeArray
