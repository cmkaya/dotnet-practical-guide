namespace ExtensionMethods;

// Static class containing extension methods  
public static class LoggerExtensions
{
    // Helper method to change console color, log, and restore the previous color
    private static void LogWithColor(ILogger logger, string message, string messageType, ConsoleColor color)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        logger.Log(message, messageType);
        Console.ForegroundColor = previousColor;
    }

    // Extension method to log an error message with red text
    public static void LogError(this ILogger logger, string errorMessage)
    {
        // Call the helper method to log with the specified color
        LogWithColor(logger, errorMessage, "Error", ConsoleColor.Red);
    }

    // Extension method to log an informational message with yellow text
    public static void LogInfo(this ILogger logger, string infoMessage)
    {
        // Call the helper method to log with the specified color
        LogWithColor(logger, infoMessage, "Info", ConsoleColor.Yellow);
    }

    // Extension method to log a login message with green text
    public static void Login(this ILogger logger, string loginMessage)
    {
        // Call the helper method to log with the specified color
        LogWithColor(logger, loginMessage, "Login", ConsoleColor.Green);
    }
}