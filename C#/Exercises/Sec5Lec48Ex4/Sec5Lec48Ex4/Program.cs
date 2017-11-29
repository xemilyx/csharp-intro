using System;
using System.Collections.Generic;

namespace Sec5Lec48Ex4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program that picks a random number between 1 and 10. 
            //Give the user 4 chances to guess the number. 
            //If the user guesses the number, display “You won"; otherwise, display “You lost". 
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

            var random = new Random();

            var secretNumber = random.Next(1, 10);
            
            Console.WriteLine("Guess the secret number: ");

            var tries = 0;

            while (tries < 4)
            {
                var guess = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    Console.WriteLine("Secret number: " + secretNumber);
                    break;
                }
                tries++;
            }

            if (tries == 4)
            {
                Console.WriteLine("You lost.");
                Console.WriteLine("Secret number: " + secretNumber);
            }
        }
    }
}