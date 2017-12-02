using System;
using System.Collections.Generic;

namespace Sec6Lec55Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter their name. 
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine().ToCharArray();

            //Use an array to reverse the name and then store the result in a new string. 
            var reverseName = new char[name.Length];
            Array.Copy(name, reverseName, name.Length);
            Array.Reverse(reverseName);

            //Display the reversed name on the console.
            foreach (var letter in reverseName)
            Console.WriteLine(letter);
        }
    }
}