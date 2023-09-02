namespace ExtensionMethods;

// Simulated console logger implementing the ILogger interface
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        // Logging to the console
        Console.WriteLine(message);
    }

    public void Log(string message, string messageType)
    {
        Log($"{messageType}: {message}");
    }
}