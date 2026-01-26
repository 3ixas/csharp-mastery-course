namespace ForEach;

class Program
{
    static void Main(string[] args)
    {
        var name = "John Doe";
        foreach (var character in name)
        {
            Console.WriteLine(character);
        }
        
        // Write a program that takes a list of numbers (comma-separated) from the user and prints each number along with its square.

        Console.WriteLine("Enter a list of numbers separated by commas:");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid - please enter some numbers");
            return;
        }

        string[] numberStrings = input.Split(',');

        foreach (string numberString in numberStrings)
        {
            bool parseSuccess = Int32.TryParse(numberString.Trim(), out int number);

            if (parseSuccess)
            {
                int square = number * number;
                Console.WriteLine($"Number: {number}, Square: {square}");
            }
            else
            {
                Console.WriteLine($"'{numberString}' is not a valid number.");
            }
        }

        var fruits = new List<string> { "Apple", "Banana", "Cherry" };
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        
    }
}
