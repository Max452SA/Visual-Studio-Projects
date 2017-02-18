using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsDemoV2
{
    class Program
    {
        //program that demos using constants including enumerated constants (enums)
        enum Ages
        {
            oldEnough = 5,
            canDrink = 21,
            tooOld = 90,
        }
        public static void Main(String[]args)
        {
            const int age = 20;

            if (age < 20)
            {

            }
             
        }
    }
}
