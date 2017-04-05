// LINQwithArrayOfObjects.cs
// LINQ to Objects querying an array of Employee Objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class LINQwithArrayOfObjects
    {
        static void Main(string[] args)
        {
            var employees = new[] {
                new Employee("Jason", "Red", 5000M),
                new Employee("Ashley", "Green", 7600M),
                new Employee("Matthew", "Indigo", 3587.5M),
                new Employee("James", "Indigo", 4700.77M),
                new Employee("Luke", "Indigo", 6200M),
                new Employee("Jason", "Blue", 3200M),
                new Employee("Wendy", "Brown", 4236.4M) };

            Console.WriteLine("\n  Original Array: ");
            Console.WriteLine();
            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }

            //filter a range of salaries using && and a LINQ query and display the array 
            var between4K6K =
                from emp in employees
                where (emp.MonthlySalary >= 4000M) && (emp.MonthlySalary <= 6000M)
                select emp;

            Console.WriteLine();
            Console.WriteLine("\n  Employees earning in the range  " +
                $" {4000:C} - {6000:C} per month: ");
            foreach (var element in between4K6K)
            {
                Console.WriteLine(element);
            }

            //order the employees by last name, then first name via LINQ
            var nameSorted = 
                from emp in employees
                orderby emp.LastName, emp.FirstName
                select emp;

            //Header
            Console.WriteLine();
            Console.WriteLine("\n  First employee when sorted by name: ");
            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("  Not Found ");
            }

            //use LINQ to select employee last names
            var lastNames =
                from emp in employees
                select emp.LastName;

            Console.WriteLine();
            Console.WriteLine("\n  Unique employee Last names: ");
            foreach (var element in lastNames.Distinct())
            {
                Console.WriteLine("  "+element);
            }

            //using LINQ to select both First and last names
            var names =
                from emp in employees
                select new { emp.FirstName, emp.LastName };

            Console.WriteLine("\n  Names Only: ");
            foreach (var element in names)
            {
                Console.WriteLine("  "+element);
            }

            Console.WriteLine();
            Console.WriteLine();
        }//end Main
    }//end class
}//end namespace
