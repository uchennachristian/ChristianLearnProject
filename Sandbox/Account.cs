namespace Sandbox;

public class Account
{

    
    public double GetCash(double amount)
    {
        if (amount > AvailableAmount)
        {
            amount = AvailableAmount;
        }

        AvailableAmount = AvailableAmount - amount;
        
        return amount;
    }

    public Human Holder { get; private set; }

    public Double AvailableAmount { get; private set; }
    
}
 