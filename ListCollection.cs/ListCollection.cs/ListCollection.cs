//ListCollection.cs
//Use of Generic List<T> coolections - simple demonstration
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
            //first create a new list of strings
            var items = new List<string>();

            Console.WriteLine();
            //display List's Count and Capacity before adding elements
            Console.WriteLine("  Before adding items: " +
                $" Count = {items.Count}; Capacity = {items.Capacity} ");

            items.Add("red");       //appends an item to the the list
            items.Insert(0, "yellow");  //inserts the value "yellow" at index 0

            //display List's Count and Capacity after adding the above two elements
            Console.WriteLine("  After adding two elements to items: " +
                $" Count = {items.Count}; Capacity = {items.Capacity} ");

            //display the colours in the list
            Console.Write("\n  Display Items list with counter controlled loop: ");
            for(var i=0; i < items.Count; i++)
            {
                Console.Write($"  {items[i]} ");
            }

            //displays colours using a foreach loop to deomnstrate functionality
            Console.Write("\n  Displays Items List using a ForEach statement: ");
            foreach(var item in items)
            {
                Console.Write($"  {item} ");
            }

            items.Add("green");     //adds "green" to the end of the list
            items.Add("yellow");    //adds "yellow" to the end of the list

            //display List's Count and Capacity after adding two more elements
            Console.WriteLine("\n\n  After adding two more elements to the list: " +
                $" Count = {items.Count}; Capacity = {items.Capacity} ");

            //display the entire list
            Console.Write("\n  List with two new elements: ");
            foreach(var item in items)
            {
                Console.Write($"  {item}");
            }

            items.Remove("yellow");     //removes the first instance of yellow in the list

            //display the new list 
            Console.WriteLine("\n\n  List after removal of first yellow: ");
            foreach (var item in items)
            {
                Console.WriteLine($"  {item}");
            }

            items.RemoveAt(1);      //remove item from list at index 1

            //display list again
            Console.WriteLine("\n  Remove second list element (green): ");
            foreach (var item in items)
            {
                Console.WriteLine($"  {item}");
            }

            //display List's Count and Capacity after removing two elements
            Console.WriteLine("\n  After removing two elements from items list: " +
                $"  Count = {items.Count}; Capacity = {items.Capacity} ");

            //check to see if a specific value is in the list
            Console.WriteLine("\n  \"red\" is"+
                $"  {(items.Contains("red") ? string.Empty : " not")} in the list");

            items.Add("orange");
            items.Add("violet");
            items.Add("blue");

            //display List's Count and Capacity after adding three elements to end of list
            Console.WriteLine("\n  After adding three more elements to the items list: " +
                $"  Count = {items.Count}; Capacity = {items.Capacity} ");

            //display the List one last time
            Console.WriteLine("\n  List with the three new elements: ");
            foreach (var item in items)
            {
                Console.WriteLine($"  {item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }//end main
    }//end class
}//end namespace