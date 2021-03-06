﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sec8Lec67Ex4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few words separated by a space. 
            //Use the words to create a variable name with PascalCase. 
            //For example, if the user types: "number of students", display "NumberOfStudents". 
            //Make sure that the program is not dependent on the input. 
            //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.WriteLine("Enter a few words separated by spaces: ");

            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = MakeVariableName(input);
            Console.WriteLine(variableName);

        }

        public static string MakeVariableName(string phrase)
        {
            //var words = new List<string>();
            var wordBuilder = new StringBuilder();

            foreach (var word in phrase.Split(' '))
            {
                //words.Add(word.ToUpper()[0] + word.Substring(1).ToLower());
                wordBuilder.Append(word.ToUpper()[0] + word.Substring(1).ToLower());
            }

            return wordBuilder.ToString();
            //foreach (var word in words)
            //Console.Write(word);
        }
    }
}