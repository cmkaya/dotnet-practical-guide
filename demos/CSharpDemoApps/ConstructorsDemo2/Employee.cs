namespace ConstructorsDemo2;

public class Employee : Person
{
    public string? EmployeeRegistrationNumber { get; set; }
    public static int EmployeeCount = 0;

    // Parameterized constructor
    public Employee(string? firstName, string? lastName, DateOnly dateOfBirth)
        : base(firstName, lastName, dateOfBirth)
    {
        EmployeeCount++;
        EmployeeRegistrationNumber = EmployeeCount.ToString();
    }
}