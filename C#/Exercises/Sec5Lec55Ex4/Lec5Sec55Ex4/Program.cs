using System;
using System.Collections.Generic;

namespace Lec5Sec55Ex4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //The list of numbers may include duplicates. Display the unique numbers that the user has entered.
            
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type Quit to exit.");
                var input = Console.ReadLine();
                Console.ReadLine();
                if (input == "Quit")
                    break;
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }
            }
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers.LastIndexOf(numbers[i]) == i)
                    Console.WriteLine(numbers[i]);
            }
        }
    }
}