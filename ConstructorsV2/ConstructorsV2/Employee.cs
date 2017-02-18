using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsV2
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int YearsOfService { get; set; }
        public int OfficeNumber { get; set; }

        //explicit constructor creation with 3 parameters
        public Employee(string name, int years, int office)
        {
            EmployeeName = name;
            YearsOfService = years;
            OfficeNumber = office;
        }

        //explicit default constructor creation with no parameters & empty braces
        public Employee()
        {

        }


    }
}
