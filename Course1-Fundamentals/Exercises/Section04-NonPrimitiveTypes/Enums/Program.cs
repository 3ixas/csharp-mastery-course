namespace Enums;

public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enums Exercise");
        Console.WriteLine("Enums are a special data type that represents a group of related constants.");
        Console.WriteLine("Enums are used to define a set of named constants.");
        Console.WriteLine("They improve code readability and maintainability.");
        
        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId);

        Console.WriteLine(method.ToString());
        Console.WriteLine(method);

        var methodName = "Express";

        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        Console.WriteLine(shippingMethod);

    }
}
