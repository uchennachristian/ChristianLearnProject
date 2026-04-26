using System.Security.AccessControl;

namespace CoffeeShop;

public static class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();

        car.Color = Colors.Green;
    }
}