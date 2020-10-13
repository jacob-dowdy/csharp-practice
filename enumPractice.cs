using System;

namespace CSharpFundamentals
{
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
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            // Example of how to convert an enum from an integer
            Console.WriteLine((ShippingMethod)methodId); // Express

            Console.WriteLine(method.ToString());

            // Example of converting/parsing a string to enumeration.
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
