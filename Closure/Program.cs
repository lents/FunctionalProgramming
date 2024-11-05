using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        void test(int c)
        {
            a = 2;
          
            Console.WriteLine(a + b);
        }
        test(a);
        
        
        // Define a function that captures a variable from its surrounding scope
        Func<int, int> adder = CreateAdder(5);

        // Use the closure to add 5 to a value
        int result = adder(10);
        Console.WriteLine(result); // Output: 15
        
        
        var counter = CreateCounter();

        // The closure remembers the state of `count` variable even after CreateCounter has finished execution.
        Console.WriteLine(counter()); // Output: 1
        Console.WriteLine(counter()); // Output: 2
        Console.WriteLine(counter()); // Output: 3
    }

    static Func<int> CreateCounter()
    {
        int count = 0; // This variable is captured by the closure

        // This lambda expression is a closure; it captures and remembers `count` even after CreateCounter exits.
        return () =>
        {
            count++; // Each call to this function increments `count`
            return count;
        };
    }

    // Function that returns a closure capturing a variable from its surrounding scope
    static Func<int, int> CreateAdder(int x)
    {
        
        // The returned lambda expression captures the variable 'x'
        return y => x + y;
    }
}
