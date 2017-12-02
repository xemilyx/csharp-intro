using System;
using System.Collections.Generic;

namespace StringsAgain
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var fullName = "Unicorn Suon ";
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(fullName.ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First name: " + names[0]);
            Console.WriteLine("Last name: " + names[1]);

            Console.WriteLine(fullName.Replace("Unicorn", "Leif Erik"));
            /*Console.WriteLine("First name: " + names[0]);
            Console.WriteLine("Last name: " + names[1]);*/

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("invalid");

            var age = "25";
            var intAge = Convert.ToByte(age);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
            //Console.WriteLine(price);

        }
    }
}