using ExtensionDemo;

string message = "This is an extension demo.";

// The first way to use the DisplayMessage extension method
message.DisplayMessage();

// The second way to use the DisplayMessage extension method
"Welcome".DisplayMessage();

string text = "check out how the 'Capitalize' extension method works!";
text.Capitalize().DisplayMessage(); // Capitalize the first letter and display

// Get the word count
int wordCount = text.GetWordCount();

// Since DisplayMessage() takes a string parameter,
// convert wordCount to string and display
wordCount.ToString().DisplayMessage();