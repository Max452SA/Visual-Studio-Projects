// Employee.cs
// Employee class with reference to other objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Date BirthDate { get; }
        public Date HireDate { get; }

        // Constructor to initialize name, birth date and date of hire
        public Employee(string firstName, string lastName, Date birthDate, Date hireDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            HireDate = hireDate;
        }

        // convert Employee to string format
        public override string ToString()
        {
            Console.WriteLine();
            return ($"  {LastName}, {FirstName}, " +
                $"Hired: {HireDate}  Date of Birth: {BirthDate}");
        }
    }//end class Employee
}//end namespace
