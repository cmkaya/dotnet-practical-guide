namespace ConstructorsDemo2;

public static class UserMessages
{
    public static void DisplayPersonInformationMessage(int number, List<Person> people, bool isEmployee = true)
    {
        string type = isEmployee is true ? "employee" : "student";

        Console.WriteLine($"The total number of {type} is {number}:");

        foreach (var person in people)
        {
            Console.WriteLine(" " + person.FirstName + " " + person.LastName);
        }

        Console.WriteLine("=====");
    }
}