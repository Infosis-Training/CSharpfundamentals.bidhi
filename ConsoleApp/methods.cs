using System;

class Methods
{
    // simplest type,no return type,no parameters
    public void Print()
    {
        // 
        Console.WriteLine("Hello There!");

    }
    // no return type, take some arguement

    public void PrintName(string name)
    {
        Console.WriteLine("Hello there!" + name);
    }

    // one return type, multiple arguments
    public string Print(string name, byte age)
    {
        string detail = $"I am {name}. I am {age} years old";
        return detail;
    }
     public string Greet(string name, string salutation = "Mr.")
    {
        return $"Hello, {salutation} {name}";
    }
}

