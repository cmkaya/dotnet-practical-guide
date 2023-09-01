namespace MethodsDemo1;

public static class UserMessages
{
    // Method that nothing returns any data.
    public static void GreetUser(string firstName)
    {
        Console.WriteLine($"*** Welcome, {firstName}! ***");
    }

    // Method overloading
    public static void GreetUser(string firstName, string lastName)
    {
        Console.WriteLine($"*** Welcome, {firstName} {lastName}! ***");
    }

    public static void PrintResultMessage(double result)
    {
        Console.WriteLine($"The result is {result}");
    }
}