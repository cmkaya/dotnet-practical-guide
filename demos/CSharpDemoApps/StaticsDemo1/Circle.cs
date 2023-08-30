namespace StaticsDemo1;

public class Circle
{
    private static double Pi = 3.14159;

    public static double CalculateArea(double radius)
    {
        return Pi * Math.Pow(radius, radius);
    }
}