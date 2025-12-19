namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        var letters = new string[3];
        letters[0] = "A";
        letters[1] = "B";
        letters[2] = "C";
        foreach (var letter in letters)
        {
            Console.WriteLine(letter);
        }

        var flags = new bool[3];
        flags[0] = true;
        flags[1] = false;
        flags[2] = true;
        foreach (var flag in flags)
        {
            Console.WriteLine(flag);
        }

        var names = new string[3] { "Alice", "Bob", "Charlie" };
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
