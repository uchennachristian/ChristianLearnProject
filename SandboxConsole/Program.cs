// Ctrl + Alt + Ins

using SandboxConsole;

// new Restaurant() - constructor / ctor / конструктор

// Что бы построить ресторан, необходимо:
// 1. Спроектировать ресторан / создать тип данных (класс)
// 2. Выделить участок под строительство ресторана / выделить (аллоцировать, зарезервировать) память
// 3. Построить ресторан / создать объект

Restaurant houseKebabRestaurant = new Restaurant("House Kebab");

houseKebabRestaurant.dishes = new Dish[3];

houseKebabRestaurant.dishes[0] = new Dish("Shawarma", 2.5);
houseKebabRestaurant.dishes[1] = new Dish("Samsa", 1.5);
houseKebabRestaurant.dishes[2] = new Dish("Kebab", 3);

houseKebabRestaurant.ShowMenu();
Console.WriteLine("Choose items of menu by numbers, separated by commas.");

string choiceString = Console.ReadLine();
string[] stringChoices = choiceString.Split(",");
Int32[] choiceNumbers = new Int32[stringChoices.Length];

for (Int32 index = 0; index < stringChoices.Length; index++)
{
    string currentItem = stringChoices[index];

    try
    {
        Int32 currentNumber = Int32.Parse(currentItem);

        choiceNumbers[index] = currentNumber;
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}

// "1,3,2" -> Split -> [ "1", "3", "2" ] -> int.Parse -> [ 1, 3, 2 ]
// "Hello" -> Split(",") -> [ "Hello" ]

// [ "1", "3", "2" ]
// [  0,   0,   0  ]
// [  1,   0,   0  ]
// [  1,   3,   0  ]
// [  1,   3,   2  ]
