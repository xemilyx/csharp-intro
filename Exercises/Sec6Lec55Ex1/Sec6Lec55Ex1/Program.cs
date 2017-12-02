using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Services;

namespace Sec6Lec55Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var names = new List<string>{};
            
            Console.WriteLine("Enter a name (or type ok to exit): ");

            var input = Console.ReadLine();

            while (input.ToLower() != "ok")
            {
                if (!String.IsNullOrWhiteSpace(input))
                    names.Add(input);
                input = Console.ReadLine();
            }

            Console.WriteLine();

            if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " likes your photo.");
            }
            if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your photo.", names[0], names[1]);
            }
            if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1}, and {2} others like your photo.", names[0], names[1], names.Count-2);
            }
            
            //Console.WriteLine("Count: " + names.Count);
        }
    }
}