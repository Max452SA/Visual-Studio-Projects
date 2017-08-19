// Employee.cs - Chapter 10 - Classes and Objects - A deeper look
// static property used to maintain a count of the number of 
// Employee objects that have been created in the employee class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeChapter10
{
    public class Employee
    {
      public static int Count { get; private set; }     // objects in memory

      public string FirstName { get; }
      public string LastName { get; }

      // intialize employee, add 1 to the static variable Count 
      // and output a string indicating that the constructor was called
      public Employee(string firstName, string lastName)
      {
            FirstName = firstName;
            LastName = lastName;
            ++Count;    // increment the static count of employees
            Console.WriteLine("  Employee Constructor: " +
                $"{FirstName} {LastName}; Count = {Count}");
      }

    }//end class Employee
}//end namespace 
