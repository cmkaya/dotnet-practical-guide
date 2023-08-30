namespace StaticsDemo2;

public static class CurrencyConverter
{
    private static Dictionary<string, double> exchangeRates = new()
    {
        { "USD", 1 },
        { "EUR", 0.9182 },
        { "TL", 26.7451 },
        { "CHF", 0.8788 }
    };

    public static double Convert(double amount, string baseCurrency, string targetCurrency)
    {
        string capitalizedBaseCurrency = baseCurrency.ToUpper();
        string capitalizedTargetCurrency = targetCurrency.ToUpper();
        
        if (!exchangeRates.ContainsKey(baseCurrency.ToUpper()) 
            || !exchangeRates.ContainsKey(targetCurrency.ToUpper()))
        {
            throw new ArgumentException("Currency is not supported.");
        }

        double rateFrom = exchangeRates[capitalizedBaseCurrency];
        double rateTo = exchangeRates[capitalizedTargetCurrency];

        return amount * (rateTo / rateFrom);
    }
}