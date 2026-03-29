namespace Sandbox;

public class CoffeeMachine
{
    
    public Coffee PrepareCoffee(int milkQuantity, int coffeeQuantity)
    {
        Console.WriteLine("Start to make coffee...");
        Thread.Sleep(TimeSpan.FromSeconds(10));

        Coffee resultCoffee = new Coffee("Capuchinno", milkQuantity + coffeeQuantity);

        Console.WriteLine("Beverage prepared");

        return resultCoffee;
    }

    public void Clean()
    {
        Console.WriteLine("Cleaning....");
        Thread.Sleep(TimeSpan.FromSeconds(10));

        bool isError = Random.Shared.Next() % 2 == 0;

        if (isError)
        {
            Console.WriteLine("Coffee-machine has an error. We can't to continue cleaning. Cleaning process will be stop.");
            
            return;
        }

        Console.WriteLine("Continue cleaning.");
        Thread.Sleep(TimeSpan.FromSeconds(10));
        Console.WriteLine("Cleaning completed.");
    }
    
}