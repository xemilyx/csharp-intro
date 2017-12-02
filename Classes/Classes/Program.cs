using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Classes.Math;

namespace Classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var emily = new Person();
            emily.FirstName = "Emily";
            emily.LastName = "Suon";
            emily.Introduce();
            
            Calculator calculator = new Calculator();
            var result = calculator.Add(2, 3);
            Console.WriteLine(result);
        }
    }
}