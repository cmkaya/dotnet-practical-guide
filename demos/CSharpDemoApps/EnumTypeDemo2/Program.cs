using EnumTypeDemo2;

DaysOfWeek today = DaysOfWeek.Tuesday;
string formattedNumber = NumberSuffix.AddNumberSuffix((int)today);

Console.WriteLine($"Today is {today}.");

switch (today)
{
    case DaysOfWeek.Sunday:
        Console.WriteLine($"It's a relaxing day and {formattedNumber} day of the week.");
        break;
    case DaysOfWeek.Monday:
        Console.WriteLine($"{formattedNumber} day of the week.");
        break;
    case DaysOfWeek.Friday:
        Console.WriteLine($"It's a last working day and {formattedNumber} day of the week.");
        break;
    default:
        Console.WriteLine($"It's a regular day and {formattedNumber} day of the week.");
        break;
}