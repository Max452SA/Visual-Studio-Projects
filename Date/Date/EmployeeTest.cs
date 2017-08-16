// EmployeeTest.cs
// Demonstration of composition using the Employee and Date classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class EmployeeTest
    {
        static void Main()
        {
            Console.WriteLine();
            var birthday = new Date(7, 24, 1949);
            var hireDate = new Date(3, 12, 1988);
            var employee = new Employee("Bob", "Blue", birthday, hireDate);

            Console.WriteLine(employee);
            Console.WriteLine();
            Console.WriteLine();
        }// end Main
    }// end class EmployeeTest
}// end namespace
