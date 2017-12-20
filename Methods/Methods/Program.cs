using System;
using System.Collections.Generic;
using System.Globalization;

namespace Methods
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            //var number = int.Parse("abc");

            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }
            
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }

        }

        static void UseParams()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(1, 2, 3));
        }
        
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
            
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            
                point.Move(100, 200);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
                throw;
            }
        }
    }
}