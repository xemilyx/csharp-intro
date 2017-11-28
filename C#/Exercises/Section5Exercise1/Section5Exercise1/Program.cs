using System;
using System.Collections.Generic;

namespace Section5Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            //Console.WriteLine(userInput);

            if (Int32.Parse(userInput) >= 0 && Int32.Parse(userInput) <= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}