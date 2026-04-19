using System.Security.AccessControl;

namespace CoffeeShop;

public static class Program
{
    public static void Main(string[] args)
    {
        CoffeeMachine coffeeMachine = new CoffeeMachine();

        coffeeMachine.Brand = "Nivona";
        coffeeMachine.Model = "CafeRomatica NICR 970";
        coffeeMachine.MilkTank = new MilkTank();
        coffeeMachine.MilkTank.Volume = 5;
        coffeeMachine.MilkTank.CurrentQuantity = 5;
        coffeeMachine.WaterTank = new WaterTank();
        coffeeMachine.WaterTank.Volume = 10;
        coffeeMachine.WaterTank.CurrentQuantity = 6;
        coffeeMachine.CoffeeBeanTank = new CoffeeBeanTank();
        
        coffeeMachine.CoffeeBeanTank.Fill(100, "Colombia Bobota");

        try
        {
            coffeeMachine.CoffeeBeanTank.Take(150);
        }
        catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine(exception.Message);
            Console.ResetColor();
        }
    }
}