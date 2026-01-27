namespace WhileLoops;

class Program
{
    static void Main(string[] args)
    {
        // When to use a while loop: when you don't know how many times you'll need to iterate

        int counter = 0;
        while (counter < 5)
        {
            Console.WriteLine($"Counter: {counter}");
            counter++;
        }

        while (true)
        {
            Console.WriteLine("Type 'exit' to quit the loop:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine($"You entered: {userInput}");
            }
        }

        while (true)
        {
            Console.WriteLine("Enter a number (or type 'quit' to exit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            bool parseSuccess = Int32.TryParse(input, out int number);

            if (!parseSuccess)
            {
                Console.WriteLine("Invalid - please enter a valid number");
                continue;
            }

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

        // Write a program that asks the user to enter a number n, then prints the multiplication table for n (from 1 to 10) using a while loop.

        Console.WriteLine("Enter a number to see its multiplication table:");
        string input1 = Console.ReadLine();
        bool parseSuccess1 = Int32.TryParse(input1, out int n);

        if (!parseSuccess1)
        {
            Console.WriteLine("Invalid - please enter a valid number");
        }
        else
        {
            int i = 1;
            while (i <= 10)
            {
                int result = n * i;
                Console.WriteLine($"{n} x {i} = {result}");
                i++;
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
