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
       public string FirstName { get; }     //read-only auto-implemented property
       public string LastName { get; }      //read-only auto-implemented property
       private decimal monthlySalary;       //monthly salary of the employee
        
       //Constructor
       public Employee(string firstName, string lastName, decimal monthlySalary)
       {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
       }

        //property to get and set an employees salary
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value >= 0M)     //validate that the salary is not negative
                {
                    monthlySalary = value;
                }
            }
        }

        //return a string containing the employees information
        public override string ToString() =>
            $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
    }//end class
}//end namespace
