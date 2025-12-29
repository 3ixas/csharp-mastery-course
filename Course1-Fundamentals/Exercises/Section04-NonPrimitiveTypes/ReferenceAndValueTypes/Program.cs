namespace ReferenceAndValueTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Reference and Value Types Exercise");
        Console.WriteLine("Reference types are stored on the heap, while value types are stored on the stack.");
        Console.WriteLine("Reference types include classes, interfaces, delegates, and arrays.");
        Console.WriteLine("Value types include structs, enums, and primitive data types.");

        var a = 10;
        var b = a;  // b is a copy of a
        b++;
        Console.WriteLine($"a: {a}, b: {b}"); // a: 10, b: 11

        var array1 = new int[] { 1, 2, 3 };
        var array2 = array1; // array2 references the same array as array1

        array2[0] = 99;
        Console.WriteLine($"array1[0]: {array1[0]}, array2[0]: {array2[0]}"); // array1[0]: 99, array2[0]: 99

        
    }
}
