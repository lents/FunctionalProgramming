using System;

class Program
{
    static void Main(string[] args)
    {
        // Define a function that captures a variable from its surrounding scope
        Func<int, int> adder = CreateAdder(5);

        // Use the closure to add 5 to a value
        int result = adder(10);
        Console.WriteLine(result); // Output: 15
    }

    // Function that returns a closure capturing a variable from its surrounding scope
    static Func<int, int> CreateAdder(int x)
    {
        
        // The returned lambda expression captures the variable 'x'
        return y => x + y;
    }
}
