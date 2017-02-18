using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Employee
    {
        public int YearsOfService { get; set; }
        public int Office { get; set; }

        public Employee(int yearsOfService, int officeNumber)       //explicit constructor - 2 parameters
        {
            YearsOfService = yearsOfService;
            Office = officeNumber;
        }

        public Employee()       //default constructor with no parameters passed
        { }
    }
}
