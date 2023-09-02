using ExtensionMethods;

// Creating an instance of the 3rd-party logger
ILogger logger = new ConsoleLogger();

// Logging a message for general purposes.
logger.Log("Test for log.");

// Using the extension methods
logger.Login("Username: johndoe");
logger.LogError("This is an error message!");
logger.LogInfo("This is an info message.");