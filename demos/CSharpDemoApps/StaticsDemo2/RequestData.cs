namespace StaticsDemo2;

public class RequestData
{
    public static string? GetAString(string message)
    {
        Console.Write(message);
        string? input = Console.ReadLine();

        return input;
    }

    public static double GetADouble(string message)
    {
        Console.Write(message);
        string? doubleText = Console.ReadLine();

        double output;
        bool isValid = double.TryParse(doubleText, out output);

        while (!isValid)
        {
            Console.WriteLine("The number was not valid. Please try again.");
            Console.Write(message);
            doubleText = Console.ReadLine();
            isValid = double.TryParse(doubleText, out output);
        }

        return output;
    }
}