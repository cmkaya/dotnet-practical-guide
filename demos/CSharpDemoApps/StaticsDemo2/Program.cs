using StaticsDemo2;

UserMessages.UserGreetingMessage();
double amount = RequestData.GetADouble("Enter the amount you want to exchange: ");

string baseCurrency = RequestData.GetAString("Enter your base currency: ")!;
string targetCurrency = RequestData.GetAString("Enter your target currency: ")!;

double convertedAmount = CurrencyConverter.Convert(amount, baseCurrency, targetCurrency);
string formattedAmount = FormatData.FormatCurrency(convertedAmount);

Console.WriteLine($"The exchanged amount is {formattedAmount}");