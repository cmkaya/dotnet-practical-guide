namespace StaticsDemo2;

public class UserMessages
{
    public static void UserGreetingMessage()
    {
        Console.WriteLine("::::Welcome to the X Exchange Office::::");

        int hour = DateTime.Now.Hour;
        
        Console.WriteLine(hour switch
        {
            < 12 => "Good morning!",
            < 17 => "Good afternoon!",
            < 21 => "Good evening!",
            _ => "Good midnight!"
        });
    }

    public static void PrintResultMessage(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine();
    }
}