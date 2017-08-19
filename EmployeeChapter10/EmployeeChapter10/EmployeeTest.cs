// EmployeeTest.cs - Chapter 10 - Classes and Objects: A Deeper look
// static member demonstration
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeChapter10
{
    class EmployeeTest
    {
        static void Main()
        {
            // show that count variable is zero before creating any employees
            Console.WriteLine($"\n  Employees before instantiation: {Employee.Count}");

            // Create two employees; Count then becomes 2 
            var e1 = new Employee("Susan", "Sarandon");
            var e2 = new Employee("Bob", "Buffet");

            // show that the Count variable is incremented to 2 after creating 2 employees
            Console.WriteLine($"\n  Employees after instantiation: {Employee.Count}");

            // get the names of Employees
            Console.WriteLine($"\n  Employee 1: {e1.FirstName} {e1.LastName}");
            Console.WriteLine($"  Employee 2: {e2.FirstName} {e2.LastName}");

            // since there is only one reference to ecah Employee, the following statements
            // cause the CLR (Common Language Runtime) to mark each Employee object as being
            // eligible for garbage collection.
            Console.WriteLine();
            Console.WriteLine();
            e1 = null;      // marks object referenced by e1 as no longer needed
            e2 = null;      // marks object referenced by e2 as no longer needed

        }//end Main
    }//end class
}//end namespace 
