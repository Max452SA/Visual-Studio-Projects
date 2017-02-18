using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Manager : Employee
    {
        //properties of public class Manager
        public bool CompanyCar { get; set; }

        //Constructor
        public Manager(string name, bool hasCar) : base(name)
        {
            CompanyCar = hasCar;
        }

        public override void TakeVacation()
        {
            vacationDays += 15; //manager gets 15 vacation days extra.
        }

        public override string ToString()
        {
            return $"  Manager. Name:{Name}, Company Car:{CompanyCar},  Vacation Days:{vacationDays} ";
        }
    }
}
