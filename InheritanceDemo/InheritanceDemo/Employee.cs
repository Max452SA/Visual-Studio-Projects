using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee
    {
        //Properties of public class Employee
        public string Name { get; set; }
        protected double vacationDays;      // N.B. protected property can be seen by this class 
                                            // and any class that derives from this class.
        public virtual void TakeVacation() { }  // virtual method - can be expected to be overwritten
                                                // in a derived class/classes. Public - can be seen by all classes

        //constructor for Employee class
        public Employee(string name)
        {
            Name = name;
        }

        public override string ToString()  //overrides ToString method and returns it's own ToString value
        {
            return $"  Employee Name:{Name}";        //returns a custom value of the Employees Name
        }
    }
}
