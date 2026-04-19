namespace Sandbox;

public class CoffeeMachine
{
    
    /// <summary>
    /// 0x0bb13412
    /// </summary>
    /// <remarks>read</remarks>
    /// <remarks>write</remarks>
    private int _milkQuantity;

    public int MilkQuantity
    {
        // read
        get
        {
            return _milkQuantity;
        }
        // write
        set
        {
            if (value >= 0)
            {
                _milkQuantity = value;
            }
        }
    }

    public void PrepareBeverage()
    {
        WaterTank waterTank = new WaterTank();
        
        Console.WriteLine("Beverage preparing.");
        waterTank.UseWater();
    }
    
}