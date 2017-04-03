// GradeBookArray.cs
// Recreating the Gradebook project using a rectangular array to store mulitple grades
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookArray
{
    class GradeBook
    {
        private int[,] gradesArray;     //rectangular array of student grades

        public string CourseName { get;}

        //Constructor for class GradeBook
        public GradeBook(string name, int[,] grades)
        {
            CourseName = name;
            gradesArray = grades;
        }

        public void DisplayMessage()
        {
            //auto-implemented property CourseName will have acquired the name 
            //of the course from the constructor
            Console.WriteLine();
            Console.WriteLine($"  Welcome to the grade book for \n  {CourseName}! ");
        }//end DisplayMessage()


        //method performs various operations on the data
        public void ProcessGrades()
        {
            //Outputs the GradesArray data
            OutputGrades();

            Console.WriteLine($"\n  The Lowest Grade is: {GetMinimumGrade()} " +
                              $"\n  The Highest Grade is: {GetMaximumGrade()} \n");

            //output the Grade Distribution chart for all grades achieved on all tests
            OutputBarChart();

        }//end ProcessGrades()

        public int GetMinimumGrade()
        {
            var lowestGrade = gradesArray[0, 0];

            foreach(var grade in gradesArray)
            {
                //if the grade is lower than the lowest grade, assign grade to lowestGrade
                if (grade < lowestGrade)
                {
                    lowestGrade = grade;
                }
            }

            return lowestGrade;
        }//end GetMinimumGrade()

        public int GetMaximumGrade()
        {
            var highestGrade = gradesArray[0, 0];

            foreach(var grade in gradesArray)
            {
                //if element in gradesArray is > highest grade, assign grade to highestGrade
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                }
            }

            return highestGrade;
        }//end GetMaximumGrade()


        public double GetAverage(int student)
        {
            //get the number of grades per student present in array
            var gradeCount = gradesArray.GetLength(1);
            var total = 0.0;

            //sums the total of all tests/exams per student
            for(var examCounter = 0; examCounter < gradeCount; ++examCounter)
            {
                total += gradesArray[student, examCounter];
            }

            //return the average of the students grades
            var average = total / gradeCount;
            return average;

        }//end GetAverage()

        public void OutputBarChart()
        {
            Console.WriteLine("  Overall Grade Distribution: ");

            //array to store frequency of grades in each range of 10 grade levels
            var frequency = new int[11];

            foreach(var grade in gradesArray)
            {
                ++frequency[grade / 10];
            }

            for (var count = 0; count < frequency.Length; count++)
            {
                //output bar chart labels e.g 100, 90-99, 80-89 etc...
                if (count == 10)
                {
                    Console.Write("      100: ");
                }
                else
                {
                    Console.Write($"  {count * 10:D2} - {count * 10 + 9:D2}: ");
                }

                //output asterisks denoting frequency distribution
                for(var stars = 0; stars < frequency[count]; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    //starts a new line of output
            }
            Console.WriteLine();
        }//end OutputBarChart

        public void OutputGrades()
        {
            Console.WriteLine("  The Grades are: \n");
            Console.Write("               ");        //align column Headers

            //Column Headings
            for (var testCount = 0; testCount < gradesArray.GetLength(1); testCount++)
            {
                Console.Write($"  Test{testCount+1} ");
            }
            Console.WriteLine("  Average");  //student average column heading

            //display rows and columns representing array grades
            for (var student = 0; student < gradesArray.GetLength(0); student++)
            {
                Console.Write($"  Student {student + 1,2}");

                //output this students grades
                for(var grade = 0; grade < gradesArray.GetLength(1); grade++)
                {
                    Console.Write($"{gradesArray[student, grade],8}");
                }

                //call method GetAverage to calculate this students average
                Console.WriteLine($"  {GetAverage(student), 9:F}");
            }
        }//end OutputGrades()

    }//end class GradeBook
}//end namespace GardeBookArray
