using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class Worker
    {
        //default constructor for worker class
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Console.WriteLine();
            Console.WriteLine("  Open a file here... ");
            Console.WriteLine();
            try
            {
                Console.WriteLine("  Throwing an Exception...");
                throw new System.Exception();
                //no code can be reached once an exception is thrown or detected by the compiler
            }
            catch
            {
                Console.WriteLine("  Handling Exception!");
            }
            finally
            {
                Console.WriteLine("  Closing File...");
                Console.WriteLine();
            }
        }
    }
}
