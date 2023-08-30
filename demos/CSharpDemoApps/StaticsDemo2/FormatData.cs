using System.Globalization;

namespace StaticsDemo2;

public class FormatData
{
    public static string FormatCurrency(double amount)
    {
        string formattedValue = amount.ToString("C", CultureInfo.CurrentCulture);

        return formattedValue;
    }
}