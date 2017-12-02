using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Remoting.Services;

namespace Iterations
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    Console.ReadLine();
                    continue;
                }

                break;
            }
/*            var i = 0;
            while (i > 0)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i--;
            }
            
            var numbers = new int[] {1, 2, 3, 4};

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            var name = "Emily Suon";
            
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }*/
            
/*            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/
        }
    }
}