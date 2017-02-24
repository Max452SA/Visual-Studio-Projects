// AutoPolicyTest.cs
// class that contains Main Method to and tests the strings in 
// switch statement from class AutPolicy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPolicy
{
    class AutoPolicyTest
    {
        public static void Main(string []args)
        {
            AutoPolicy policy1 = new AutoPolicy(11111111, "Toyota Camry", "NJ");
            AutoPolicy policy2 = new AutoPolicy(22222222, "Ford Fusion", "ME");

            PolicyInNoFaultState(policy1); //calls static method PolicyInNoFaultState
            PolicyInNoFaultState(policy2); 
        }// end Main

        public static void PolicyInNoFaultState(AutoPolicy policy)  //passes in a policy object as a parameter
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  The Auto Policy: ");
            Console.Write($"  Account #: {policy.AccountNumber};");
            Console.WriteLine($"  Car: {policy.MakeAndModel};");
            Console.Write($"  State: {policy.State}");

            if (policy.IsNoFaultState)
            {
                Console.WriteLine(" is a No-Fault state");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(" is not a No-Fault state");
                Console.WriteLine();
            }

            }// end method PolicyInNoFaultState

    }// end class AutoPolicyTest

}// end namespace AutoPolicy
