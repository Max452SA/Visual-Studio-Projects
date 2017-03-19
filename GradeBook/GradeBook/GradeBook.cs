// GradeBook.cs
// version of the GradeBook exercise using arrays to store test grades
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBook
    {
        private int[] gradesArray;      //this is the array of student grades

        //getter only auto implemented property CourseName
        public string CourseName { get; }

        //Constructor
        public GradeBook(string name, int[] grades)
        {
            CourseName = name;
            gradesArray = grades;   //initializes gradesArray
        }

        public void DisplayMessage()
        {
            //auto implemented CourseName gets the name of the course from user
            Console.WriteLine();
            Console.WriteLine($"  Welcome to the Grade Book for \n  {CourseName}!");
        }

        //method that performs various operations on the data 
        public void ProcessGrades()
        {
            //method to output the gradesArray
            OutputGrades();

            Console.WriteLine();
            //call method GetAverage to calculate the average grade
            Console.WriteLine($"  The Class Average is: {GetAverage():F}");

            //call methods GetMinimum and GetMaximum to display lowest and highest grade
            Console.WriteLine($"  The Lowest grade is: {GetMinimum()}");
            Console.WriteLine($"  The Highest grade is: {GetMaximum()}");

            //call method OutputBarChart to display the grade distribution chart
            OutputBarChart();

        }//end ProcessGrades

        //method GetMinimum returns the lowest grade
        public int GetMinimum()
        {
            var lowestGrade = gradesArray[0];

            foreach (var grade in gradesArray)
            {
                if (grade < lowestGrade)
                {
                    lowestGrade = grade;    //new lowest grade if lowest grade < grade
                }
            }
            return lowestGrade;
        }//end GetMinimum

        //method GetMaximum returns the highest grade
        public int GetMaximum()
        {
            var highestGrade = gradesArray[0];

            foreach (var grade in gradesArray)
            {
                if (grade > highestGrade)
                {
                    highestGrade = grade;   //new highest grade if element in array > highestGrade
                }
            }
            return highestGrade;
        }//end GetMaximum

        //method GetAverage determines the average grade for the test
        public double GetAverage()
        {
            var total = 0.0;    //intialize total as type double

            //sum all the students grades from the gradesArray
            foreach (var grade in gradesArray)
            {
                total += grade;
            }

            double average = total / gradesArray.Length;
            return average;

        }//end GetAverage

        //method OutputBarChart displays Grade distribution
        public void OutputBarChart()
        {
            Console.WriteLine();
            Console.WriteLine("  Grade Distribution: ");

            //array to store frequency of grades in each range of 10 grades
            var frequency = new int[11];

            //for each grade increment the appropriate frequency element
            foreach (var grade in gradesArray)
            {
                ++frequency[grade / 10];
            }

            //for each grade frequency, display bar in chart
            for (var count = 0; count < frequency.Length; count++)
            {
                if (count == 10)
                {
                    Console.Write("          100: ");
                }
                else
                {
                    Console.Write($"        {count * 10:D2}-{count * 10 + 9:D2}: ");
                }

                //display bar of asterisks
                for (var stars = 0; stars < frequency[count]; stars++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }//end for
            Console.WriteLine();

        }//end method OutputBarChart

        //output the contents of the gradesArray
        public void OutputGrades()
        {
            Console.WriteLine();
            Console.WriteLine("  The Grades are:\n");

            for (var studentCount = 0; studentCount < gradesArray.Length; ++studentCount)
            {
                Console.WriteLine($"  Student {studentCount+1,2}: {gradesArray[studentCount],3}");
            }
        }//end OutputGrades

    }//end class GradeBook
}//end namespace GradeBook
