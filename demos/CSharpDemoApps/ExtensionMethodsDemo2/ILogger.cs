namespace ExtensionMethods;

// Simulated 3rd-party logger interface
public interface ILogger
{
    void Log(string message);
    void Log(string message, string messageType);
}