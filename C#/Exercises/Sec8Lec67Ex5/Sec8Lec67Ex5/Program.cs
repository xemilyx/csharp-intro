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
            var vowelCount = CountVowels(Console.ReadLine().ToLower());
            Console.WriteLine(vowelCount);
        }

        public static int CountVowels(string word)
        {
            var vowels = new List<char> {'a', 'e', 'i', 'o', 'u'};

            var vowelCount = 0;
            
            foreach (var letter in word)
            {
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}