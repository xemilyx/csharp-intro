using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Services;

namespace Sec6Lec55Ex5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
            //otherwise, display the 3 smallest numbers in the list.

            while (true)
            {
                Console.WriteLine("Enter a series of numbers separated by commas: ");
                var numberList = Console.ReadLine().Split(',');
                if (numberList.Length < 5)
                {
                    Console.WriteLine("Invalid List. Try Again.");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    Array.Sort(numberList);
                    for (var i = 0; i < 3; i++)
                    {
                        Console.Write(numberList[i] + " ");
                    }
                    break;
                }
            }
            
        }
    }
}