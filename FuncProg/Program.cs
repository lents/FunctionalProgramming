using System;

class Program
{
    static void ApplyOperation(int[] numbers, Func<int, int> operation)
    {
        foreach (int number in numbers)
        {
            // Apply the operation to each number and print the result
            Console.WriteLine(operation(number));
        }
    }
    static int Square(int x) => x * x;
    static int Cube(int x) => x * x * x;

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Squares:");
        ApplyOperation(numbers, Square);

        Console.WriteLine("Cubes:");
        ApplyOperation(numbers, Cube);
    }
}
