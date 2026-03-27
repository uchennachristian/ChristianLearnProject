namespace SandboxConsole;

/// <summary>
/// Cat.
/// </summary>
public class Cat
{

    /// <summary>
    /// Cat's nickname.
    /// </summary>
    public string name;

    /// <summary>
    /// Cat's age.
    /// </summary>
    public int age;

    /// <summary>
    /// Cat's on diet.
    /// </summary>
    public bool isOnDiet;

    /// <summary>
    /// Make's cat jump.
    /// </summary>
    public void Jump()
    {
        Console.WriteLine("jump jump");
    }

    /// <summary>
    /// Makes cat scratch.
    /// </summary>
    public void Scratch()
    {
        Console.WriteLine("scratch scratch");
    }

    /// <summary>
    /// Performs feeding.
    /// </summary>
    /// <param name="dishName">Name of food.</param>
    public void Eat(string dishName)
    {
        DateTime now = DateTime.Now;

        if (now.Hour >= 13 && now.Hour <= 18 || !isOnDiet)
        {
            Console.WriteLine("I'm eating " + dishName);
        }
        else
        {
            Console.WriteLine("I can't eat. I'm on a diet");
        }
    }
    
    /// <summary>
    /// Cat drinks.
    /// </summary>
    /// <param name="drinkName">Name of drink.</param>
    public void Drink(string drinkName)
    {
        Console.WriteLine("I'm drinking " + drinkName);
    }
}