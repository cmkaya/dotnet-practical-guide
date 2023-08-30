namespace StaticsDemo1;

public class RequestData
{
    public static string? GetAString(string? input)
    {
        Console.Write(input);
        string? output = Console.ReadLine();

        return output;

    }
    public static double GetADouble(string message)
    {
        string? numberText = message;
        
        double output;
        bool isValid = double.TryParse(numberText, out output);
        
        while (isValid is false)
        {
            Console.WriteLine("Invalid number. Please try again.");
            Console.WriteLine(message);
            numberText = Console.ReadLine();
        
            isValid = double.TryParse(numberText, out output);
        }
        
        return output;
    }
}