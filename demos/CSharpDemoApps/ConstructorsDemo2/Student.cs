namespace ConstructorsDemo2;

public class Student : Person
{
    public string? StudentRegistrationNumber { get; set; }
    public static int StudentCount = 0;

    // Parameterized constructor
    public Student(string? firstName, string? lastName, DateOnly dateOfBirth)
        : base(firstName, lastName, dateOfBirth)
    {
        StudentCount++;
        StudentRegistrationNumber = StudentCount.ToString();
    }
}