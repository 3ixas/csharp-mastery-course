namespace ConditionalStatements3;

class Program
{
    static void Main(string[] args)
    {
        // Write a program which takes two numbers from the console and displays the maximum of the two.

        Console.WriteLine("Please enter a number: ");
        string userInput1 = Console.ReadLine();
        var resultA = Int32.TryParse(userInput1, out int userInputInt1);

        Console.WriteLine("Please enter another number: ");
        string userInput2 = Console.ReadLine();
        var resultB = Int32.TryParse(userInput2, out int userInputInt2);

        if (!resultA || !resultB)
        {
            Console.WriteLine("Invalid - please enter a number");
        }
        else if (userInputInt1 == userInputInt2)
        {
            Console.WriteLine($"{userInputInt1} is the same as {userInputInt2}, so both are the maximum number");
        }
        else if (userInputInt1 > userInputInt2)
        {
            Console.WriteLine($"{userInputInt1} is the maximum of the two numbers");
        }
        else
        {
            Console.WriteLine($"{userInputInt2} is the maximum of the two numbers");
        }

    }
}
