// Fig 3.13: Welcome4.cs
// Inserting content into a string using string interpolation (new to C# 6)

using System;

class Welcome4
{
    //Main Method of class Welcome4 that executes this C# app
    public static void Main()
    {
        string person = "Mridul";
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"\t\t\t\t\t\t Welcome to \n\t\t\t\t\t C# 6 programming, {person}!");
        Console.WriteLine();
    } //end Main method
}  //end class Welcome4


