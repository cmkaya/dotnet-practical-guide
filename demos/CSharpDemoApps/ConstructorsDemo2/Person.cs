namespace ConstructorsDemo2;

public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Parameterized constructor
    protected Person(string? firstName, string? lastName, DateOnly dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}