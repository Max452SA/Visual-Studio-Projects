// AutoPolicy.cs
// simple Auto insurance policy class representing a car insurance policy

namespace AutoPolicy
{
    class AutoPolicy
    {
        // Properties of class AutoPolicy
        public int AccountNumber { get; set; }
        public string MakeAndModel { get; set; }
        public string State { get; set; } // Two-letter state abbreviation of US State

        // Constructor
        public AutoPolicy(int accountNum, string makeAndModel, string usState)
        {
            AccountNumber = accountNum;
            MakeAndModel = makeAndModel;
            State = usState;
        }

        // property isNoFaultState returns whether the state has No-Fault insurance policies
        public bool IsNoFaultState
        {
            get
            {
                bool noFaultState; // local bool variable to determine a No Fault state

                switch (State)
                {
                    case "MA":
                    case "NJ":
                    case "NY":
                    case "PA":
                        noFaultState = true;
                        break;
                    default:
                        noFaultState = false;
                        break;
                }// end switch

                return noFaultState;
            }// end get

        }// end bool isNoFaultState

    }// end class AutoPolicy
}// end namespace AutoPolicy
