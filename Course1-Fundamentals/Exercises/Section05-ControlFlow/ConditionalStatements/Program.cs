namespace ConditionalStatements;

class Program
{

    public enum Seasons
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Conditional Statements Exercise");
        Console.WriteLine("Use if, else if, and else statements to control program flow.");
        Console.WriteLine("Conditional statements help make decisions based on conditions.");
        
        var temperature = 25;
        if (temperature > 30)
        {
            Console.WriteLine("It's a hot day.");
        }
        else if (temperature > 20)
        {
            Console.WriteLine("It's a nice day.");
        }
        else
        {
            Console.WriteLine("It's a cold day.");
        }

        int hour = 10;

        if (hour > 0 && hour < 12)
        {
            Console.WriteLine("Good morning!");
        }
        else if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("Good afternoon!");
        }
        else if (hour >= 18 && hour < 21)
        {
            Console.WriteLine("Good evening!");
        }
        else
        {
            Console.WriteLine("Good night!");
        }

        bool isRaining = false;
        if (isRaining)
        {
            Console.WriteLine("Take an umbrella.");
        }
        else
        {
            Console.WriteLine("No need for an umbrella.");
        }

        bool isGoldCustomer = true;
        float price;
        if (isGoldCustomer)
        {
            price = 19.95f;
        }
        else
        {
            price = 29.95f;
        }
        Console.WriteLine($"Price: {price}");
        float finalPrice = (isGoldCustomer) ? 19.95f : 29.95f;
        Console.WriteLine($"Final Price: {finalPrice}");

        var season = Seasons.Autumn;
        switch (season)
        {
            case Seasons.Spring:
                Console.WriteLine("It's spring!");
                break;
            case Seasons.Summer:
                Console.WriteLine("It's summer!");
                break;
            case Seasons.Autumn:
                Console.WriteLine("It's autumn!");
                break;
            case Seasons.Winter:
                Console.WriteLine("It's winter!");
                break;
            default:
                Console.WriteLine("Unknown season!");
                break;
        }

    }
}
