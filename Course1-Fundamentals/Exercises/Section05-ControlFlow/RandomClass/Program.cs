namespace RandomClass;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Random class
        Random random = new Random();

        // Generate a random integer between 1 and 100
        int randomNumber = random.Next(1, 101);
        Console.WriteLine($"Random number between 1 and 100: {randomNumber}");

        // Generate a random double between 0.0 and 1.0
        double randomDouble = random.NextDouble();
        Console.WriteLine($"Random double between 0.0 and 1.0: {randomDouble}");

        // Generate a random integer within a specified range (e.g., 50 to 150)
        int randomInRange = random.Next(50, 151);
        Console.WriteLine($"Random number between 50 and 150: {randomInRange}");

        // Simulate rolling a six-sided die
        int dieRoll = random.Next(1, 7);
        Console.WriteLine($"Die roll result: {dieRoll}");

        // Simulate drawing a random card from a standard deck of 52 cards
        int cardNumber = random.Next(1, 53);
        Console.WriteLine($"Card drawn from a deck of 52 cards: {cardNumber}");

        // Generate a random password of a specified length
        const int passwordLength = 10;
        const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
        var passwordChars = new char[passwordLength];
        for (int i = 0; i < passwordLength; i++)
        {
            int index = random.Next(validChars.Length);
            passwordChars[i] = validChars[index];
        }
        string password = new string(passwordChars);
        Console.WriteLine($"Generated password: {password}");

    }
}
