namespace Records
{   

    public record Employee(int Id, string Name, string Position, decimal Salary);

    class Program
    {
        static void Main()
        {
            var employee = new Employee(1, "Alice Johnson", "Software Developer", 75000m);
            Console.WriteLine($"Original Employee: {employee}");

            var promotedEmployee = employee with { Position = "Senior Software Developer", Salary = 90000m };
            Console.WriteLine($"Promoted Employee: {promotedEmployee}");
        }
    }

}
