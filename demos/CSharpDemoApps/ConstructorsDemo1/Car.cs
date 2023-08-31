namespace ConstructorsDemo1;

public class Car
{
    public string? Brand { get; set; }

    // parameterless constructor
    public Car(string brand)
    {
        Brand = brand;
        Console.WriteLine("Explicit (parameterless) constructor has executed for \"Car\".");
    }

    // copy constructor
    public Car(Car car)
    {
        Brand = car.Brand;
        Console.WriteLine("Copy constructor has executed for  \"Car\".");
    }
}