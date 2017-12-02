using System;
using System.Collections.Generic;

namespace Sec8Lec67Ex5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter an English word. 
            //Count the number of vowels (a, e, o, u, i) in the word. 
            //So, if the user enters "inadequate", the program should display 6 on the console.

            Console.WriteLine("Enter a word: ");
            var input = Console.ReadLine();

            var vowels = new List<char> {'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};

            var vowelCount = 0;
            
            foreach (var letter in input)
            {
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);

        }
    }
}