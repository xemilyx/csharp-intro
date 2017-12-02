using System;
using System.Collections.Generic;

namespace Section5Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program that asks the user to enter the speed limit. 

            Console.WriteLine("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            //Once set, the program asks for the speed of a car. 
            Console.WriteLine("Enter the speed of the car: ");
            var speed = Convert.ToInt32(Console.ReadLine());
            
            //If the user enters a value less than the speed limit, program should display Ok on the console. 
            if (speed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demerits = (speed - speedLimit) / 5;
                Console.WriteLine("Demerit Points: " + demerits);
                if (demerits > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
            
            
            //If the value is above the speed limit, the program should calculate the number of demerit points. 
            //For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
            //If the number of demerit points is above 12, the program should display License Suspended.
        }
    }
}