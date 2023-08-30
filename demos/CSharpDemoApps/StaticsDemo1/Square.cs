namespace StaticsDemo1;

public class Square
{
    public static double CalculateArea(double side)
    {
        return Math.Pow(side, 2);
    }

    public static double CalculatePerimeter(double side)
    {
        return 4 * side;
    }
}