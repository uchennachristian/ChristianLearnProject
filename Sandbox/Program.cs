namespace Sandbox;

public class Program
{
    /// <summary>
    /// Entry point.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        Cat cat = new Cat("Napoleon", 5);

        cat.Drink("Milk");
        Console.ReadLine();
    }
}