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
            //initialize a new array of employees
            var employees = new[]
            {
                new Employee("  Jason","  Red",5000M),
                new Employee("  Ashley","  Green",7600M),
                new Employee("  Matthew","  Indigo",3587.5M),
                new Employee("  James","  Indigo",4700.77M),
                new Employee("  Luke","  Indigo",6200M),
                new Employee("  Jason","  Blue",3200M),
                new Employee("  Wendy","  Brown",4236.4M)
            };

            //display all employees
            Console.WriteLine("  Original Array: ");
            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }

            //filter a range of salaries using && in a LINQ query
            var between4K6K =
                from emp in employees
                where (emp.MonthlySalary >= 4000M) && (emp.MonthlySalary <= 6000M)
                select emp;

            //display all employees earning between 4000 and 6000 per month
            Console.WriteLine("\n  Employees earning in the range" +
                $" {4000:C}-{6000:C} per month:");
            foreach (var element in between4K6K)
            {
                Console.WriteLine(element);
            }

            //order the employees by last name, then first name using LINQ
            var nameSorted = 
                from emp in employees
                orderby emp.LastName, emp.FirstName
                select emp;

            //header
            Console.WriteLine("\n  First employee when sorted by name: ");

            //display the 1st result form the LINQ query
            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine(" Not found ");
            }

            //use LINQ to select employee last names
            var lastNames =
                from emp in employees
                select emp.LastName;

            //use method Distinct to select unique last names
            Console.WriteLine("\n  Unique employee last names: ");
            foreach (var element in lastNames.Distinct())
            {
                Console.WriteLine(element);
            }

            //now using LINQ to select first and last names 
            var names =
                from emp in employees
                select new { emp.FirstName, emp.LastName };

            //display full name
            Console.WriteLine("\n  Names only: ");
            foreach (var element in names)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }//end class
}//end namespace
