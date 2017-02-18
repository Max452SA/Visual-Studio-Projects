using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //public class Worker is derived from parent (Super) class Employee and so 
    //inherits all the attributes and properties of the parent class as well.
    public class Worker : Employee  
    {
        // Properties of public class Worker 
        public double HourlyWage { get; set; }

        // Constructor
        public Worker(string name, double wage) : base(name)
        {
            HourlyWage = wage;
        }

        public override void TakeVacation()
        {
            vacationDays += 10;             //overrides the TakeVacation method and adds 10 days to vacationDays variable
        }

        public override string ToString()
        {
            return $"  Worker. Name:{Name}, Hourly Wage:{HourlyWage}, Vacation:{vacationDays} ";
        }
    }
}
