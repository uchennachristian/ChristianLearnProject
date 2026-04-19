namespace CoffeeShop;

public class CoffeeMachine
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public MilkTank MilkTank { get; set; }
    public RecycleBin RecycleBin { get; set; }
    public Tray Tray { get; set; }
    public WaterTank WaterTank { get; set; }
    public CoffeeBeanTank CoffeeBeanTank { get; set; }
}