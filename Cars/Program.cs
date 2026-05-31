using System.Text;

namespace Cars;

public static class Program
{
    
    public static void Main(string[] args)
    {
        Car car = new SUV();

        car = new SUV();
        car = new Truck();
        car = new Pickup();
        
        RepairCar(new Truck());

        while (true)
        {
            car = new SUV();
        }
    }

    private static void RepairCar(Car truck)
    {
        Console.WriteLine("We sale some car.");
    }
    
}