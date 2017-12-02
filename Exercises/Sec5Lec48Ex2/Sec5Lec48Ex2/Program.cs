using System;
using System.Collections.Generic;

namespace Sec5Lec48Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        //Write a program and continuously ask the user to enter a number or "ok" to exit. 
        //Calculate the sum of all the previously entered numbers and display it on the console.
            var total = 0;
            
            Console.WriteLine("Enter a number or ok to exit");
            var input = Console.ReadLine();
            Console.ReadLine();
            
            while (input.ToLower() != "ok")
            {
                total += Convert.ToInt32(input);
                input = Console.ReadLine();
                Console.ReadLine();
            }
            
            Console.WriteLine(total);
        }
    }
}