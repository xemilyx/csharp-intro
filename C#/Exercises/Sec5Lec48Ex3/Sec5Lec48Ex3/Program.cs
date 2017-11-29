using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Services;

namespace Sec5Lec48Ex3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter a number. 
            //Compute the factorial of the number and print it on the console. 
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;

            for (var i = number; i > 0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}