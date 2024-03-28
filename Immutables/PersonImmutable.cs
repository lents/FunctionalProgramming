// See https://aka.ms/new-console-template for more information
public class PersonImmutable
{
    public string FirstName { get; }
    public string LastName { get; }

    public PersonImmutable(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Person WithFirstName(string firstName)
    {
        return new Person(firstName, LastName);
    }

    public Person WithLastName(string lastName)
    {
        return new Person(FirstName, lastName);
    }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}";
    }
}
