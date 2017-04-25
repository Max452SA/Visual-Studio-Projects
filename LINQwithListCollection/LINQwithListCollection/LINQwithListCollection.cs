// LINQwithListCollection.cs
// LINQ to Objexts using a List<string>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQwithListCollection
{
    class LINQwithListCollection
    {
        static void Main(string[] args)
        {
            var items = new List<string>();
            items.Add("aQua");
            items.Add("RusT");
            items.Add("yElLow");
            items.Add("rEd");

            Console.WriteLine();
            Console.WriteLine();
            //display the initial list
            Console.Write("  items contains: ");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            //converts to uppercase, selects those starting with R, and sort the list
            var startsWithR =
                from item in items
                let upperCaseString = item.ToUpper()
                where upperCaseString.StartsWith("R")
                orderby upperCaseString
                select upperCaseString;

            Console.Write("  Results of the query startsWithR: ");
            foreach(var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            items.Add("rUbY");
            items.Add("SaFFRon");

            Console.WriteLine();
            //display list items again
            Console.Write("  items contains: ");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            Console.Write("  Results of query startsWithR: ");
            foreach(var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }//end main
    }//end class
}//end namespace
