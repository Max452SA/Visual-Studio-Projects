// GradeBookTest.cs
// Creates a gradebook object using a rectangular array of grades
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookArray
{
    class GradeBookTest
    {
        static void Main(string[] args)
        {
            //input a rectangular array of student grades
            int[,] grades = { { 87,96,70},
                              { 68,87,90},
                              { 94,100,90},
                              { 100,81,82},
                              { 83,65,85},
                              { 78,87,65},
                              { 85,75,83},
                              { 91,94,100},
                              { 76,72,84 },
                              { 87,93,73 } };

            GradeBook myGradeBook = new GradeBook("CS101 Intro to C# programming", grades);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();

        }//end Main

    }//end class GradeBookTest
}//end namespace GradeBook Array
