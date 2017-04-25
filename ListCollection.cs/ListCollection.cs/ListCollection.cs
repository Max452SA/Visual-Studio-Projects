// ListCollection.cs
// first use and example of a Generic List<T> collection
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class ListCollection
    {
        static void Main(string[] args)
        {
            // create a new List of Strings
            var items = new List<string>();

            Console.WriteLine();
            Console.WriteLine("  Before adding new items: " +
                $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add("red");       //append a new item to the list
            items.Insert(0, "yellow");      //inserts the value yellow at index 0

            Console.WriteLine("  After adding two elements to the items List: " +
                $"Count = {items.Count} ; Capacity = {items.Capacity}");

            Console.WriteLine();
            // display the colours in the list
            Console.Write("\n  Display list contents with a counter controlled loop: ");
            for (var count = 0; count < items.Count; count++)
            {
                Console.Write($"  {items[count]}");
            }

            //display the colours using a foreach loop
            Console.Write("\n  Display list contents with a foreach loop: ");
            foreach (var item in items)
            {
                Console.Write($"  {item}");
            }

            items.Add("green");     //adds the item 'green' to the end of the list
            items.Add("yellow");

            Console.WriteLine();
            //Displays the lists count and capacity after adding two more elements
            Console.WriteLine("\n  After adding two more elements to items: " + 
                $" Count = {items.Count} ; Capacity {items.Capacity} ");

            Console.Write("  List with two new elements: ");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            items.Remove("yellow");     //remove the first "yellow" from the list

            Console.WriteLine();
            Console.Write("\n  Remove the first instance of Yellow: ");
            foreach(var item in items)
            {
                Console.Write($"  {item}");
            }

            items.RemoveAt(1);      //remove the item located at index 1

            Console.Write("\n  Remove second list element (green): ");
            foreach (var item in items)
            {
                Console.Write($"  {item}");
            }

            Console.WriteLine("\n  After removing two elements from items: " +
                $" Count = {items.Count} ; Capacity {items.Capacity} ");

            //Checking to see if a particular value is in the list
            Console.WriteLine("\n  \"red\" is " +
                $"{(items.Contains("red") ? string.Empty : "not ")} in the list");

            items.Add("orange");
            items.Add("violet");
            items.Add("blue");

            Console.WriteLine("\n  After adding three more elements to items: " + 
                $"Count = {items.Count} ; Capacity = {items.Capacity} ");

            Console.Write("  List with three new elements: ");
            foreach (var item in items)
            {
                Console.Write($"  {item}");
            }
            Console.WriteLine();
            Console.WriteLine();

        }//end main
    }//end class
}//end namespace
