using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        public static void Main(string[]args)
        {
            Employee emp = new Employee(5, 101);

            Console.WriteLine();
            Console.WriteLine($"  Employee years of Service: {emp.YearsOfService }");
            Console.WriteLine($"  Employee Office Number: {emp.Office}");

            Employee emp2 = new Employee();
            emp2.YearsOfService = 15;
            emp2.Office = 201;
            Console.WriteLine();
            Console.WriteLine($"  Employee2 years of Service: {emp2.YearsOfService }");
            Console.WriteLine($"  Employee2 Office Number: {emp2.Office}");

            Employee emp3 = new Employee()
            {
                YearsOfService = 20,
                Office = 301
            };
            Console.WriteLine();
            Console.WriteLine($"  Employee3 years of Service: {emp3.YearsOfService }");
            Console.WriteLine($"  Employee3 Office Number: {emp3.Office}");
        }
    }


}
