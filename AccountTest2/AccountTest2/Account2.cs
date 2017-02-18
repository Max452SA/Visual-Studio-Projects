// Fig 4.6: Account2.cs
// Account class that replaces public methods SetName and 
// GetName with a public Name Property

public class Account
{
    // Variable declaration
    private string name;

    // Property Name to get and set the private instance variable name
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;   //value is implicitly declared and initialized
        }
    }//end property Name
}// end class Account