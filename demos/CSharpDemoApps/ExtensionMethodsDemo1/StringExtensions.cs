namespace ExtensionDemo;

public static class StringExtensions
{
    // Extension method to display a string message
    public static void DisplayMessage(this string message)
    {
        Console.WriteLine(message);
    }

    // Extension method to capitalize the first letter of a string
    public static string Capitalize(this string text)
    {
        // If the input string is null or empty, return it as is;
        // otherwise, capitalize the first letter.
        return string.IsNullOrEmpty(text)
            ? text
            : char.ToUpper(text[0]) + text.Substring(1);
    }

    // Extension method to count the number of words in a string
    public static int GetWordCount(this string text)
    {
        // If the input string is null or empty, return 0;
        // otherwise, count non-empty words.
        return string.IsNullOrEmpty(text)
            ? 0
            : text.Split(new char[] { ' ', '.', ',', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
    }
}