// Employee.cs
// Employee class with employees FirstName, LastName, and MonthlySalary properties.
// Example of querying using LINQ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public string FirstName { get; }        //read-only autoimplemented property
        public string LastName { get; }         //read-only auto-implemented property
        private decimal monthlySalary;

        //Constructor
        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        //get and set the employees monthly salary
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value >= 0M)
                {
                    monthlySalary = value;
                }
            }
        }

        //return a string containing all the Employee information
        public override string ToString() =>
            $"  {FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";

    }//end class
}//end namespace
