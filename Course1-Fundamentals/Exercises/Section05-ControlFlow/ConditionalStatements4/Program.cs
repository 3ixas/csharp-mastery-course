namespace ConditionalStatements4;

class Program
{
    static void Main(string[] args)
    {
        // Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

        Console.WriteLine("Please enter the width of your image: ");
        string widthInput = Console.ReadLine();
        bool widthParse = Int32.TryParse(widthInput, out int widthInt);

        Console.WriteLine("Please enter the height of your image: ");
        string heightInput = Console.ReadLine();
        bool heightParse = Int32.TryParse(heightInput, out int heightInt);

        if (!widthParse || !heightParse)
        {
            Console.WriteLine("Invalid - please enter a numerical width and height");
        }
        else if (widthInt == heightInt)
        {
            Console.WriteLine("This is a square image");
        }
        else if (widthInt > heightInt)
        {
            Console.WriteLine("This is a landscape image");
        }
        else
        {
            Console.WriteLine("This is a portrait image");
        }


    }
}
