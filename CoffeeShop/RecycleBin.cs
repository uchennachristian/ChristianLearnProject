namespace CoffeeShop;

public class RecycleBin
{
    private int _volume;
    private int _currentQuantity;

    public int Volume
    {
        get
        {
            return _volume;
        }
        set
        {
            if (_volume >= 0)
            {
                _volume = value;
            }
            
        }
    }

    public int CurrentQuantity
    {
        get
        {
            return _currentQuantity;
        }
        set
        {
            if (value >= 0 && value <= Volume)
            {
                _currentQuantity = value;
            }
        }
    }
}