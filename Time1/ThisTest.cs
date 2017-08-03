// ThisTest.cs
// this used implicitly and explicitly to refer to members of an object
using System;

class ThisTest
{
    static void Main()
	{
        var time = new SimpleTime(15, 30, 19);
        Console.WriteLine(time.BuildString());
	}
}

// class SimpleTime demonstrates the "this" reference
public class SimpleTime
{
    private int hour;   // from 0-23
    private int minute; // from 0-59
    private int second; // from 0-59

    // if the constructor uses parameter names identical to instance variable names 
    // the "this" reference is required to distinguish between variable names
    public SimpleTime(int hour, int minute, int second)
    {
        this.hour = hour;   // sets "this" objects hour instance variable
        this.minute = minute;
        this.second = second;
    }

    // use implicit and explicit "this" call to call ToUniversalString
    public string BuildString() =>
        $"  {"this.ToUniversalString()",24}: {this.ToUniversalString()}" +
        $"\n  {"ToUniversalString()",24}: {ToUniversalString()}";

    // convert to string in Universal Time Format (HH:MM:SS) "this" is not required 
    // here to access instance variables, because the method does not local variables
    // with the same names as the instance variables
    public string ToUniversalString() =>
        $"  {this.hour:D2}:{this.minute:D2}:{this.second:D2}";

}// end class ThisTest
