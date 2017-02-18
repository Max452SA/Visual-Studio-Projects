using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemoV2
{
    class Program
    {
        public static void Main(string[]args)
        {

            Employee tony = new Employee();             //instantiating a new Object tony of type Employee
            tony.Income = 150000;                       // object tony has property/attribute income of 150000
            tony.YearsOfService = 8;                    // tony has Years of service of 8
            tony.SetRating(Employee.Rating.excellent);  //SetRating method is called to assign a value of excellent for his rating
            tony.CalculateRaise();
        }

        public class Employee
        {
            public enum Rating
            {
                poor,
                good,
                excellent,
            }

            private Rating rating;  //private member variable of type Rating belonging to the Employee class

            public double Income { get; set; }  //property of Class Employee - Income

            public int YearsOfService { get; set; } //type property  - Years of Service

            public void SetRating(Rating rating)    //SetRating method with parameter of type Rating passed to it
            {
                this.rating = rating;
            }

            public void CalculateRaise()
            {
                double baseRaise = Income * 0.05;
                double bonus = YearsOfService * 1000;
                Income += baseRaise + bonus;

                switch (rating)
                {
                    case Rating.poor:
                        Income -= YearsOfService * 2000;
                        break;
                    case Rating.good:
                        break;
                    case Rating.excellent:
                        Income += YearsOfService * 500;
                        break;
                }

                Console.WriteLine();
                Console.WriteLine($" Employee's New Income is: {Income} ");
                Console.WriteLine();
            }

        }
    }
}
