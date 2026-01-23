namespace ConditionalStatements5;

class Program
{
    static void Main(string[] args)
    {
        // Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

        Console.WriteLine("What is the speed limit?");
        string speedLimitInput = Console.ReadLine();
        bool speedLimitParse = Int32.TryParse(speedLimitInput, out int speedLimitInt);

        Console.WriteLine("What is the speed of your car?");
        string carSpeedInput = Console.ReadLine();
        bool carSpeedParse = Int32.TryParse(carSpeedInput, out int carSpeedInt);

        if (!speedLimitParse || !carSpeedParse)
        {
            Console.WriteLine("Invalid - please enter a valid number");
        }
        else if (carSpeedInt <= speedLimitInt)
        {
            Console.WriteLine("Ok");
        }
        else
        {
            int howMuchOver = carSpeedInt - speedLimitInt;
            int demeritPoints = howMuchOver / 5;

            if (demeritPoints > 12)
            {
                Console.WriteLine("License Suspended");
            }
            else
            {
                Console.WriteLine($"You now have {demeritPoints} demerit points");
            }
        }
    }
}
