// Fig 5.5: StudentTest.cs
// Create and test Student objects
using System;

public class StudentTest
{
    public static void Main()
    {
        Student student1 = new Student(" Jane Green", 93);
        Student student2 = new Student(" John Blue", 72);

        Console.WriteLine();
        Console.WriteLine();
        Console.Write($" {student1.Name} has an average of: {student1.Average}");
        Console.WriteLine($" and the Lettergrade equivalent of {student1.LetterGrade}");

        Console.Write($" {student2.Name} has an average of: {student2.Average}");
        Console.WriteLine($" and the Lettergrade equivalent of {student2.LetterGrade}");
        Console.WriteLine();
        Console.WriteLine();

    } //end Main
}// end class StudentTest