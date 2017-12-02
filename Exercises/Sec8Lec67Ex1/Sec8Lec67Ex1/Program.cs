using System;
using System.Collections.Generic;
using System.Globalization;

namespace Sec8Lec67Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //Work out if the numbers are consecutive. 
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
            //"Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Enter a series of numbers separated by hyphens: ");

            var numbers = Console.ReadLine().Split('-');
            
            if (DetermineConsecutive(numbers))
                Console.WriteLine("Consecutive");
            else
            {
                Console.WriteLine("Not consecutive");
            }
        }

        public static bool DetermineConsecutive(string[] numbers)
        {
            var sortedNumbers = new string[numbers.Length];
            Array.Copy(numbers, sortedNumbers, numbers.Length);
            Array.Sort(sortedNumbers);

            var isConsecutive = true;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != sortedNumbers[i])
                    isConsecutive = false;
            }

            return isConsecutive;
        }
    }
}