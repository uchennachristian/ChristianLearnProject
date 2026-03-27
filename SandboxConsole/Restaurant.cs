namespace SandboxConsole;

public class Restaurant
{
    public string name;
    public Dish[] dishes;

    public Restaurant(string name)
    {
        this.name = name;
    }

    public void ShowMenu()
    {
        if (dishes == null)
        {
            Console.WriteLine("Error occured. List of dishes isn't available.");
            
            return;
        }
        
        Console.WriteLine(name + " has the following dishes:");

        for (int index = 0; index < dishes.Length; index++)
        {
            Dish dish = dishes[index];
            int prefix = index + 1;
            
            Console.WriteLine(prefix + ". " + dish.name + " ($" + dish.price + ")");
        }
    }
}

// 1. Shawarma ($2.5)
// 2. Samsa ($1.5)
// 3. Kebab ($3)