namespace ConsoleApp1;

public class Human
{

    // Auto-property
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    // Nickname
    // Weight
    // Height

    public string NickName { get; set; }

    private double weight;


    public double Weight
    {
        get
        {
            return weight;
        }
        set
        {
            if (value > 0)
            {
                weight = value;
            }
        }
    }

    private double height;

    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value > 0)
            {
                height = value;
            }
        }
        
    }
    
    private int age;

    // Property
    
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }

    public Human(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.age = age;
    }

    public void Hello()
    {
        Console.WriteLine("Hello, World.");
    }

    public void Eat(string dishName)
    {
        Console.WriteLine("nyam nyam " + dishName);
    }

    public double GetUSD()
    {
        // Calculate sum
        return 10.5;
    }

    /// <summary>
    /// Does something.
    /// </summary>
    /// <param name="arg1">String arg.</param>
    /// <param name="arg2">Number arg.</param>
    /// <returns>Returns some string.</returns>
    public string SomeMethod(string arg1, int arg2)
    {
        Console.WriteLine("Do something " + arg1 + " " + arg2);

        return "some result";
    }
    
}