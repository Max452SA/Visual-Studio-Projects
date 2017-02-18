using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsV2
{
    class Program
    {
        public static void Main(string []args)
        {
            //instantiation of employee object using the explicit constructor created in 
            //the Employee Class. 
            Employee emp = new Employee("Dave", 5, 101);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"   Employee Name:  {emp.EmployeeName}");
            Console.WriteLine($"   Employee Years of Service:  {emp.YearsOfService}");
            Console.WriteLine($"   Employee Office Number:  {emp.OfficeNumber}");
            Console.WriteLine();


            //instatiation of an employee object using the default constructor 
            // (has to be explicit if an explicit constructor has already been created
            Employee emp2 = new Employee();
            emp2.EmployeeName = "Susan";
            emp2.YearsOfService = 5;
            emp2.OfficeNumber = 201;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"   Employee Name:  {emp2.EmployeeName}");
            Console.WriteLine($"   Employee Years of Service:  {emp2.YearsOfService}");
            Console.WriteLine($"   Employee Office Number:  {emp2.OfficeNumber}");
            Console.WriteLine();


            //instantiation method 3 - adding values directly to the object
            Employee emp3 = new Employee()
            {
                EmployeeName = "Sipho",
                YearsOfService = 20,
                OfficeNumber = 301
            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"   Employee Name:  {emp3.EmployeeName}");
            Console.WriteLine($"   Employee Years of Service:  {emp3.YearsOfService}");
            Console.WriteLine($"   Employee Office Number:  {emp3.OfficeNumber}");
            Console.WriteLine();
        }
    }


}
