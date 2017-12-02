using System;
using System.Collections.Generic;

namespace Sec8Lec67Ex3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
            //If the user doesn't provide any values, consider it as invalid time. 

            Console.WriteLine("Enter a time in 24-hour time format (e.g. 7 PM = 19:00): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
                
            var timeCheck = CheckTime(input.Split(':'));

            Console.WriteLine(timeCheck);
            
        }

        public static string CheckTime(string[] time)
        {
            if (time.Length != 2)
            {
                return "Invalid Time";
            }

            var hours = Convert.ToInt32(time[0]);
            var minutes = Convert.ToInt32(time[1]);

            if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
            {
                return "Ok";
            }
            else
            {
                return "Invalid Time";
            }
        }
    }
}