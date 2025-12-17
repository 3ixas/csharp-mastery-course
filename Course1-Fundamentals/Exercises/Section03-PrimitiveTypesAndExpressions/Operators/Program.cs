using System;
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            // Addition
            int sum = a + b;
            Console.WriteLine($"Addition: {a} + {b} = {sum}");

            // Subtraction
            int difference = a - b;
            Console.WriteLine($"Subtraction: {a} - {b} = {difference}");

            // Multiplication
            int product = a * b;
            Console.WriteLine($"Multiplication: {a} * {b} = {product}");

            // Division
            int quotient = a / b;
            Console.WriteLine($"Division: {a} / {b} = {quotient}");

            // Modulus
            int remainder = a % b;
            Console.WriteLine($"Modulus: {a} % {b} = {remainder}");

            // Increment
            a++;
            Console.WriteLine($"Increment: a++ = {a}");

            // Decrement
            b--;
            Console.WriteLine($"Decrement: b-- = {b}");

            // Compound Assignment
            a += 5;
            Console.WriteLine($"Compound Assignment: a += 5 = {a}");

            b *= 2;
            Console.WriteLine($"Compound Assignment: b *= 2 = {b}");

            // Comparison Operators
            Console.WriteLine($"Comparison: a == b: {a == b}"); 
            Console.WriteLine($"Comparison: a != b: {a != b}");
            Console.WriteLine($"Comparison: a > b: {a > b}");
            Console.WriteLine($"Comparison: a < b: {a < b}");
            Console.WriteLine($"Comparison: a >= b: {a >= b}");
            Console.WriteLine($"Comparison: a <= b: {a <= b}");

            // Logical Operators
            bool condition1 = true;
            bool condition2 = false;
            Console.WriteLine($"Logical AND: {condition1 && condition2}");
            Console.WriteLine($"Logical OR: {condition1 || condition2}");
            Console.WriteLine($"Logical NOT: {!(condition1 && condition2)}");

            var c = 10;
            var d = 3;
            var result = c + d * 2; // Multiplication has higher precedence than addition
            Console.WriteLine($"Operator Precedence: c + d * 2 = {result}");
            Console.WriteLine((float)c + (float)d); // Casting to float for explicit conversion
            Console.WriteLine(c > d ? "c is greater than d" : "c is not greater than d"); // Ternary operator
            Console.WriteLine(c > d && d > 0 ? "Both conditions are true" : "At least one condition is false"); // Ternary with logical operators
        }
    }
}