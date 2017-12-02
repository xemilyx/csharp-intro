using System;
using System.Collections.Generic;

namespace Sec8Lec67Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //If the user simply presses Enter, without supplying an input, exit immediately; 
            //otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            Console.WriteLine("Enter a series of numbers separated by hyphens: ");
            var input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
            {
                var numberArray = input.Split('-');
                var i = 0;
                while (i < numberArray.Length)
                {
                    if (Array.IndexOf(numberArray, numberArray[i], i + 1) != -1)
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }

                    i++;
                }
                
            }
        }
    }
}