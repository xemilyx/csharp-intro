using System;
using System.Collections.Generic;

namespace Sec5Lec48Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            //Display the count on the console.

            var i = 1;
            var count = 0;
            while (i <= 100)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine(count);
        }
    }
}