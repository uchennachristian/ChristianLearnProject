namespace Sandbox;

public class Account
{
    private Human holder;
    private double availableAmount;
    
    public double GetCash(double amount)
    {
        if (amount > availableAmount)
        {
            amount = availableAmount;
        }

        availableAmount = availableAmount - amount;
        
        return amount;
    }


    public Human GetHolder()
    {
        return holder;
    }

    public void SetHolder(Human value)
    {
        holder = value;
    }

    public double GetAvailableAmount()
    {
        return availableAmount;
    }

    public void SetAvailableAmount(double value)
    {
        availableAmount = value;
    }
}