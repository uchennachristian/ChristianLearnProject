namespace CoffeeShop;

public class Car
{

    private int _currentSpeed;

    public int CurrentSpeed
    {
        get
        {
            return _currentSpeed;
        }
        set
        {
            if (value <= MaxSpeed)
            {
                _currentSpeed = value;
            }
        }
    }
    
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public Colors Color { get; set; }
    public int Year { get; private set; }
    public int MaxSpeed { get; set; }

    public void Drive(string destination, DateTime departureTime)
    {
        Console.WriteLine("Now is " + departureTime + ". We are going to " + destination + ".");
    }
    
}