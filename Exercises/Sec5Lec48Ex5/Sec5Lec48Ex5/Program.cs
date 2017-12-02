using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Sec5Lec48Ex5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter a series of numbers separated by comma. 
            //Find the maximum of the numbers and display it on the console. 
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

/*            Console.WriteLine("Enter a series of numbers separated by commas: ");
            var input = Console.ReadLine();*/

/*            var max = 0;
            
            foreach (var character in input)
            {
                if (Char.IsDigit(character))
                {
                    //Console.WriteLine(character);
                    if (Convert.ToInt32(character.ToString()) > max)
                    {
                        max = Convert.ToInt32(character.ToString());
                    }
                }
            }

            Console.WriteLine(max);*/

            Console.WriteLine("Enter a series of numbers separated by commas: ");
            var input = Console.ReadLine();
            
            var numberArray = input.Split(',');

            var max = Convert.ToInt32(numberArray[0].Trim());

            foreach (var str in numberArray)
            {
                if (!String.IsNullOrEmpty(str) && !String.IsNullOrWhiteSpace(str) && Convert.ToInt32(str.Trim()) > max)
                {
                    max = Convert.ToInt32(str.Trim());
                }
            }

            Console.WriteLine(max);

        }
    }
}