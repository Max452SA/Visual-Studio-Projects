// Fig 5.4 Student.cs
// Student class that stores a student name and average
using System;

public class Student
{
    public string Name { get; set; } //property Name
    private int average;  //private instance variable average

    // Constructor
    public Student(string studentName, int studentAverage)
    {
        Name = studentName;
        Average = studentAverage; 
    }

    public int Average
    {
        get
        {
            return average;
        } //end get
        set
        {
            if ((value > 0) && (value <=100))
            {
                average = value;  //private instance variable average assigned the default value 
                // passed into Property Average
            }
        } //end set
    }

    public string LetterGrade
    {
        get
        {
            string LetterGrade = string.Empty;

            if (average >= 90)
            {
                LetterGrade = "A";
            }
            else if (average >= 80 )
            {
                LetterGrade = "B";
            }
            else if (average >= 70)
            {
                LetterGrade = "C";
            }
            else if (average >= 60)
            {
                LetterGrade = "D";
            }
            else if (average >= 50)
            {
                LetterGrade = "E";
            }
            else
            {
                LetterGrade = "F";
            }

            return LetterGrade;
        }// end get
    }
}// end class Student
