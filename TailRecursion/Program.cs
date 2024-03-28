using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        Console.WriteLine($"Factorial of {n} is: {Factorial(n)}");
    }

    static int Factorial(int n)
    {
        return FactorialTail(n, 1);
    }

    static int FactorialTail(int n, int acc)
    {
        if (n == 0)
            return acc;
        else
            return FactorialTail(n - 1, n * acc);
    }
}
