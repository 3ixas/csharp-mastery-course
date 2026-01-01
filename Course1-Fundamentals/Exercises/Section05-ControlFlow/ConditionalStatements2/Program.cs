namespace ConditionalStatements2;

class Program
{
    static void Main(string[] args)
    {
        // Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

        Console.WriteLine("Please enter a number between 1 and 10");

        string userInput = Console.ReadLine();
        bool result = Int32.TryParse(userInput, out int userInputInt);

        if (!result)
        {
            Console.WriteLine("Invalid - please enter a number between 1 and 10");
        }
        else if (userInputInt >= 1 && userInputInt <= 10)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid - number must be between 1 and 10");
        }

    }
}
