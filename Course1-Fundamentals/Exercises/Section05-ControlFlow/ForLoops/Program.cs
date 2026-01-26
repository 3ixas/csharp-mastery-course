namespace ForLoops;

class Program
{
    static void Main(string[] args)
    {
        for (var i = 0; i < 1; i++)
        {
            Console.WriteLine("This is a for loop that runs only once.");
        }

        for (var i = 0; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        for (var i = 10; i >= 1; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        
        // Write a program that asks the user to enter a number n, then prints the sum of the first n natural numbers (1 to n).

        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        bool parseSuccess = Int32.TryParse(input, out int n);

        if (!parseSuccess || n < 1)
        {
            Console.WriteLine("Invalid - please enter a positive integer");
        }
        else
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
        }
    }
}
