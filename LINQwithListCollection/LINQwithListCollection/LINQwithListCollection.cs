// LINQWithListCollection.cs
// LINQ to Objects using a List<string>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQwithListCollection
{
    class LINQWithListCOllection
    {
        static void Main()
        {
            // Populate a new list of strings
            var items = new List<string>();
            items.Add("aQua");      // add "aQua" to the end of the list
            items.Add("RusT");      // add "RusT" to the end of the list
            items.Add("yElLow");
            items.Add("rEd");

            // display your initial list
            Console.Write("\n\n  items contains: ");
            foreach (var item in items)
            {
                Console.Write($"  {item}");
            }

            Console.WriteLine();        // output the end of line

            // convert all items in list to uppercase, select those starting with "R" 
            // then sort the list
            var startsWithR =
                from item in items
                let uppercaseString = item.ToUpper()
                where uppercaseString.StartsWith("R")
                orderby uppercaseString
                select uppercaseString;

            // display the above query's results
            Console.Write("  results of the query startsWithR: ");
            foreach (var item in startsWithR)
            {
                Console.Write($"  {item}");
            }

            Console.WriteLine();    // output the end of line

            items.Add("rUbY");      // adds "rUbY" to the end of the list
            items.Add("SaFfRon");   // adds "SaFfRon" to the end of the list

            // now display intial list
            Console.Write("\n  items contains: ");
            foreach (var item in items)
            {
                Console.Write($"  {item}");
            }

            Console.WriteLine();    // output the end of line

            // display the update query results
            Console.Write("  results of query startsWithR: ");
            foreach (var item in startsWithR)
            {
                Console.Write($"  {item}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }//end Main
    }//end class
}//end namespace
