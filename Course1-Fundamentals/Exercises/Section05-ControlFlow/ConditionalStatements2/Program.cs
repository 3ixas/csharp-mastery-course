namespace ConditionalStatements2;

class Program
{
    static void Main(string[] args)
    {
        // Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

        string userInput = Console.ReadLine();
        Int32.TryParse(userInput, out int userInputInt);
        // bool conversionSucceeded = Int32.TryParse(userInput, out int userInputInt);

        if (userInputInt >= 1 && userInputInt <= 10)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }


    }
}
