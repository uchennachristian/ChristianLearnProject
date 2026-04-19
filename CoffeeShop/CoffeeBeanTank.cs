namespace CoffeeShop;

public class CoffeeBeanTank
{
    public CoffeeBean[] Beans { get; set; }

    public void Fill(int quantity, string sort)
    {
        Beans = new CoffeeBean[quantity];

        for (int index = 0; index < Beans.Length; index++)
        {
            Beans[index] = new CoffeeBean();

            Beans[index].Size = 5;
            Beans[index].Sort = sort;
        }
    }

    public CoffeeBean[] Take(int quantity)
    {
        if (quantity > Beans.Length)
        {
            Exception exception = new Exception("You attempted to take more coffee bean than available.");
            
            throw exception;
        }

        return null;
    }
}