namespace Sandbox;

public class Person
{

    private string sex;
    private DateTime birthdayDate;

    // Compute-properties
    // Вычисляемые свойства
    
    public int Age
    {
        get
        {
            // Timeline
            //                       DateTime   [                                TimeSpan                         ] DateTime
            // -------------------[ birthdate ]----------------------------------------------------------------------[ now ]---->
            // Calculate age based on birthday date.
            // TimeSpan = now - birthday_date

            TimeSpan span = DateTime.Now - BirthdayDate;
            int age = span.Days / 365;

            return age;
        }
    }

    public DateTime BirthdayDate
    {
        get
        {
            return birthdayDate;
        }
        private set
        {
            if (value <= DateTime.Now)
            {
                birthdayDate = value;
            }
        }
    }

    public string Sex
    {
        get
        {
            return sex;
        }
        set
        {
            if (value is "Female" or "Male")
            {
                sex = value;
            }
        }
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }

    public string NickName { get; set; }
    
    public string Login { get; set; }

    public Person(string firstName, string lastName, string sex, DateTime birthdayDate)
    {
        FirstName = firstName;
        LastName = lastName;
        Sex = sex;
        BirthdayDate = birthdayDate;
    }
    
    public void DrinkCoffee(Coffee coffee)
    {
        Console.WriteLine("I'm drinking " + coffee.Name);
    }

}