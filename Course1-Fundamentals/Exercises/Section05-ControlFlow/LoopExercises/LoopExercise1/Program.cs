namespace LoopExercise1;

class Program
{
    static void Main(string[] args)
    {
        // Note: for all these exercises, ignore input validation unless otherwise directed. Assume the user enters a value in the format that the program expects. For example, if the program expects the user to enter a number, don't worry about validating if the input is a number or not. When testing your program, simply enter a number.

        // 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

        var noRemainderCount = 0;
        
        for (var i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                noRemainderCount += 1;
            }
        }

        Console.WriteLine($"There are {noRemainderCount} numbers between 1 and 100 that are divisible by 3 with no remainder.");
    
    }
}
