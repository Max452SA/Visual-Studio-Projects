using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee tony = new Employee();
            tony.Income = 150000;
            tony.YearsofService = 8;
            tony.SetRating(Employee.Rating.excellent);
            tony.CalculateRaise();
        }

        public class Employee
        {
            /// <summary>
            /// public class Employee holds all the employee information for an employee 
            /// when instantiated, and does all the work required in the main method.
            /// enum Rating lists the employee rating level - either poor, good, excellent,
            /// private member variable rating creates a private member variable 
            /// of type Rating (name of variable is rating)
            /// Method SetRating assigns the rating of the employee to the Employee.Rating varaible from main method
            /// Method CalculateRaise calculates the bonus due to the employee
            /// And the current income of the employee is then written to screen 
            /// with a simple Console.WriteLine statement.
            /// </summary>

            public enum Rating
            {
                poor,
                good,
                excellent
            }

            private Rating rating;

            public double Income { get; set; } //creating an Income property of type double
            public int YearsofService { get; set; } //creating a Years of Service property of type integer

            public void SetRating(Rating rating)
            {
                this.rating = rating;  //assigns the method parameter rating to the Employee.rating variable
            }

            public void CalculateRaise()
            {
                double baseRaise = Income * .05;
                double bonus = YearsofService * 1000;
                Income += baseRaise + bonus;

                switch (rating)
                {
                    case Rating.poor:
                        Income -= YearsofService * 2000;
                        break;
                    case Rating.good:
                        break;
                    case Rating.excellent:
                        Income += YearsofService * 500;
                        break;
                }

                //Simple WriteLine statement outputs the employees new current income on screen
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"   New (Current) Income is: {Income} ");
            }

        }
    }
}
