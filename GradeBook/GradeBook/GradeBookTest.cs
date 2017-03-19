// GradeBookTest.cs
// demonstrates GradeBook class by creating a GradeBook object using an array of Grades
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBookTest
    {
        static void Main(string[] args)
        {
            int[] grades = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

            var myGradeBook = new GradeBook("CS101 - Introduction to C# Programming", grades);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();
        }//end Main
    }//end class GradeBookTest
}//end namespace GradeBook
