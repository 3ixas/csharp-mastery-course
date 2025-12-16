using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion from int to double
            int intValue = 42;
            double doubleValue = intValue; // No cast needed
            Console.WriteLine($"Implicit conversion from int to double: {doubleValue}");

            // Explicit conversion from double to int
            double anotherDoubleValue = 42.99;
            int anotherIntValue = (int)anotherDoubleValue; // Cast needed
            Console.WriteLine($"Explicit conversion from double to int: {anotherIntValue}");

            // Using Convert class for string to int conversion
            string stringValue = "123";
            int convertedIntValue = Convert.ToInt32(stringValue);
            Console.WriteLine($"Converted string to int: {convertedIntValue}");

            // Using Parse method for string to double conversion
            string anotherStringValue = "456.78";
            double parsedDoubleValue = double.Parse(anotherStringValue);
            Console.WriteLine($"Parsed string to double: {parsedDoubleValue}");

            byte b = 1;
            int i = b; // Implicit conversion from byte to int
            Console.WriteLine($"Implicit conversion from byte to int: {i}");

            double d = 9.78;
            int j = (int)d; // Explicit conversion from double to int 
            Console.WriteLine($"Explicit conversion from double to int: {j}");

            try
            {
                var number = "1234";
                byte n = Convert.ToByte(number); // This will throw an exception
                Console.WriteLine($"Converted string to byte: {n}");
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Cannot convert string '1234' to byte as it exceeds byte range.");
            }

            try
            {
                string str = "true";
                bool boolValue = bool.Parse(str); // Parsing string to bool
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Cannot parse string to bool.");
            }
        }
    }
}