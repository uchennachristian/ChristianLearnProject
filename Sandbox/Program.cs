namespace Sandbox;

public class Program
{
    /// <summary>
    /// Entry point.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        Person person = new Person("Christian", "Uchenna", "Male", new DateTime(1982, 3, 10));

        Console.WriteLine(person.BirthdayDate);
        Console.WriteLine(person.Age);
    }
}