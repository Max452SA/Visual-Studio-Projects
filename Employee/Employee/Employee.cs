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
        public string FirstName { get; }    //read-only auto implemented property
        public string LastName { get; }     //read-only auto implemented property
        private decimal monthlySalary;      //motnly salary of the employee

        //Constructor
        //Initializes first name, last name, and monthly salary
        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        //Property to get and set an employees monthly salary
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value >= 0M)    //validate that the salary is non-negative
                {
                    monthlySalary = value;
                }
            }
        }

        //Return a string containing the employee's information
        public override string ToString()
        {
            return $"{FirstName,-10} {LastName,-10} {MonthlySalary,-10:C}";
        }
    }//end class
}//end namespace
