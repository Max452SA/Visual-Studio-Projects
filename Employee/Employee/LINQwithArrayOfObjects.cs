// LINQwithArrayOfObjects.cs
// LINQ to Objects querying an array of Employee Objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class LINQWithArrayOfObjects
    {
        static void Main(string []args)
        {
            //Initialize an array of employees
            var employees = new[]
            {
                new Employee("  Jason", "  Red", 5000M),
                new Employee("  Ashley", "  Green", 7600M),
                new Employee("  Matthew", "  Indigo", 3587.5M),
                new Employee("  James", "  Indigo", 4700.77M),
                new Employee("  Luke", "  Indigo", 6200M),
                new Employee("  Jason", "  Blue", 3200M),
                new Employee("  Wendy", "  Brown", 4236.4M)
            };

            //Display all employees
            Console.WriteLine();
            Console.WriteLine("  Original Array:");
            foreach(var element in employees)
            {
                Console.WriteLine(element);
            }

            //Filter a range of salaries using && in a LINQ Query
            var between4K6K =
                from e in employees
                where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
                select e;

            //Display all employees making between 4000 and 6000 per month
            Console.WriteLine("\n  Employees earning in the range " +
                $"{4000:C} - {6000:C} per month: ");
            foreach(var element in between4K6K)
            {
                Console.WriteLine(element);
            }

            //Order employees by last name, then first name with a LINQ query
            var nameSorted =
                from e in employees
                orderby e.LastName, e.FirstName
                select e;

            //header
            Console.WriteLine("\n  First employee when sorted by name: ");

            //attempt to display the 1st result of the above LINQ query
            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("  Not Found! ");
            }

            //Use a LINQ query to select all employees last names
            var lastNames =
                from e in employees
                select e.LastName;

            //use method Distinct to select unique last names amongst employees
            Console.WriteLine("\n  Unique employee last names: ");
            foreach(var element in lastNames.Distinct())
            {
                Console.WriteLine(element);
            }

            //Use LINQ to select first names and last names
            var names =
                from e in employees
                select new { e.FirstName, e.LastName };

            //Display full names
            Console.WriteLine("\n  Names Only: ");
            foreach(var element in names)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
   
}//end namespace
