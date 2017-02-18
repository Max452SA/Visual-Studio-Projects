// Fig 4.11: Account.cs
// Account class with a balance and a Deposit Method

class Account
{
    public string Name { get; set; } //property Name of type string
    private decimal balance; //private instance variable balance

    // Constructor for Account
    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance;
    }

    //Balance Property with Validation
    public decimal Balance
    {
        get
        {
            return balance; //returns value stored in private instance variable balance 
        }//end get

        private set //private so that it can only be used in this class
        {
            if (value > 0.0m) //m used to demarcate decimal values
            {
                balance = value; //value is the auto assigned variable for set accessor (initialBalance)
            }//end if
        }//end set

    }//end public decimal Balance prop

    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m)
        {
            Balance = Balance + depositAmount;
        }
    }//end method Deposit

}//end class Account
