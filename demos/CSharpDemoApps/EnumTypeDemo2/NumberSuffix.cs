namespace EnumTypeDemo2;

public static class NumberSuffix
{
    public static string AddNumberSuffix(int number)
    {
        if (number is >= 11 and <= 13)
        {
            return number + "th";
        }

        return (number % 10) switch
        {
            1 => number + "st",
            2 => number + "nd",
            3 => number + "rd",
            _ => number + "th"
        };
    }
}