namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        string firstName = "John";
        string lastName = "Doe";

        // Concatenation
        string fullNameConcat = firstName + " " + lastName;
        Console.WriteLine("Full Name (Concatenation): " + fullNameConcat);

        // Interpolation
        string fullNameInterp = $"{firstName} {lastName}";
        Console.WriteLine("Full Name (Interpolation): " + fullNameInterp);

        // Using String.Format
        string fullNameFormat = string.Format("{0} {1}", firstName, lastName);
        Console.WriteLine("Full Name (String.Format): " + fullNameFormat);

        // Verifying all methods produce the same result
        bool areEqual = fullNameConcat == fullNameInterp && fullNameInterp == fullNameFormat;
        Console.WriteLine("All methods produce the same result: " + areEqual);

        // Using String.Join
        string[] nameParts = { firstName, lastName };
        string fullNameJoin = string.Join(" ", nameParts);
        Console.WriteLine("Full Name (String.Join): " + fullNameJoin);

        // Verifying String.Join result
        bool isJoinEqual = fullNameJoin == fullNameConcat;
        Console.WriteLine("String.Join produces the same result as concatenation: " + isJoinEqual);

        // Using /newline character
        string multiLineName = $"{firstName}\n{lastName}";
        Console.WriteLine("Full Name (Multi-line): " + multiLineName);

        // Using verbatim string literal
        string verbatimString = @"First Name: " + firstName + "\n" + @"Last Name: " + lastName;
        Console.WriteLine("Verbatim String Literal:\n" + verbatimString);

        // Using StringBuilder for efficient string manipulation
        var stringBuilder = new System.Text.StringBuilder();
        stringBuilder.Append("Full Name (StringBuilder): ");
        stringBuilder.Append(firstName);
        stringBuilder.Append(" ");
        stringBuilder.Append(lastName);
        Console.WriteLine(stringBuilder.ToString());

        // Verifying StringBuilder result
        bool isStringBuilderEqual = stringBuilder.ToString().EndsWith(fullNameConcat);
        Console.WriteLine("StringBuilder produces the same result as concatenation: " + isStringBuilderEqual);

        // Summary
        Console.WriteLine("\nSummary:");
        Console.WriteLine($"Concatenation: {fullNameConcat}");
        Console.WriteLine($"Interpolation: {fullNameInterp}");
        Console.WriteLine($"String.Format: {fullNameFormat}");
        Console.WriteLine($"String.Join: {fullNameJoin}");
        Console.WriteLine($"Multi-line:\n{multiLineName}");
        Console.WriteLine($"Verbatim String Literal:\n{verbatimString}");
        Console.WriteLine($"StringBuilder: {stringBuilder.ToString()}");
    }
}
