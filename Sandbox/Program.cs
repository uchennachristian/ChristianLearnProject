namespace Sandbox;

public class Program
{
    /// <summary>
    /// Entry point.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        CoffeeMachine coffeeMachine = new CoffeeMachine();

        coffeeMachine.MilkQuantity = 10;

        Console.WriteLine("Good morning");
        Console.WriteLine(coffeeMachine.MilkQuantity);
        coffeeMachine.PrepareBeverage();
    }
}