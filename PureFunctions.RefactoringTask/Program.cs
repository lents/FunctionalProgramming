class Program
{

    public static string greeting = "Hello";
    static void Main(string[] args)
    {
        var john = new Person("John", "Doe");
        Console.WriteLine(Greet(john));
    }

    static string Greet(Person person, string greeting = "Hello")
    {
        return $"{greeting}, {person?.FirstName} {person?.LastName}";
    }
}

class Person
{
    public string FirstName { get; }
    public string LastName { get; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
