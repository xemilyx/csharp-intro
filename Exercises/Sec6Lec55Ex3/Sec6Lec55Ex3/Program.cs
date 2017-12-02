using System;
using System.Collections.Generic;

namespace Sec6Lec55Ex3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter 5 numbers. 
            //If a number has been previously entered, display an error message and ask the user to re-try. 
            //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            var numbers = new int[5];

            var count = 0;

            while (count < 5)
            {
                Console.WriteLine("Enter a new number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                if (Array.IndexOf(numbers, input) == -1)
                {
                    numbers[count] = input;
                    count++;
                }
                else
                {
                    Console.WriteLine("Error. Try again. ");
                }
            }
            
            Array.Sort(numbers);
            foreach (var number in numbers)
                Console.Write(number + " ");
        }
    }
}