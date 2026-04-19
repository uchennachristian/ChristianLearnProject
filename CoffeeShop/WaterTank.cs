namespace CoffeeShop;

public class WaterTank
{
    
    private int _volume;

    public int Volume
    {
        get
        {
            return _volume;
        }
        set
        {
            if (value > 0)
            {
                _volume = value;
            }
        }
    }
    
    private int _currentQuantity;
    
    public int CurrentQuantity
    {
        get
        {
            return _currentQuantity;
        }
        set
        {
            // Current quantity should be (more or equals zero) AND (less or equal volume)
            if (value >= 0 && value <= Volume)
            {
                _currentQuantity = value;
            }
        }
    }
    
    // Compute-property IsEmpty
    // Вычисляемое свойство

    public bool IsEmpty
    {
        get
        {
            return CurrentQuantity == 0;
        }
    }
    
    // Compute-property IsFull
    // Вычисляемое свойство

    public bool IsFull
    {
        get
        {
            return CurrentQuantity == Volume;
        }
    }
    
}