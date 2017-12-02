using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Enums
{

    public enum ShippingMethod
    {
        RegularAirmail = 1,
        RegisteredAirmail = 2,
        Express = 3
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}