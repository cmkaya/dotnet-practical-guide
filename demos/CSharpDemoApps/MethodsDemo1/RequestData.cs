namespace MethodsDemo1;

public class RequestData
{
    public static double GetADouble(string message)
    {
        double output;

        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool isValid = double.TryParse(input, out output);

            if (isValid && output > 0)
            {
                return output;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive value.");
            }
        }
    }
}