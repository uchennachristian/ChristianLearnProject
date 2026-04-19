namespace CoffeeShop;

/// <summary>
/// Coffee bean.
/// </summary>
public class CoffeeBean
{

    /// <summary>
    /// Size of the coffee bean.
    /// </summary>
    private int _size;
    
    /// <summary>
    /// Size of the coffee bean.
    /// </summary>
    public int Size
    {
        get
        {
            return _size;
        }
        set
        {
            if (value > 0)
            {
                _size = value;
            }
        }
    }
    
    /// <summary>
    /// Coffee sort.
    /// </summary>
    public string Sort { get; set; }
    
}