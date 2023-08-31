namespace ConstructorsDemo1;

public class Animal
{
    private static int animalCounter;

    // explicit (parameterless) constructor
    public Animal()
    {
        Console.WriteLine("Explicit constructor has executed for \"Animal\".");
    }

    // static constructor
    static Animal()
    {
        animalCounter++;
        Console.WriteLine($"Static constructor has executed  \"Animal\". Animal counter: {animalCounter}");
    }
}