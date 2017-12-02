using System;
using System.Collections.Generic;

namespace Section5Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            
            Console.ReadLine();
            
            Console.WriteLine("Enter the width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            var orientation = (height > width) ? "portrait" : "landscape";
            Console.WriteLine(orientation);
        }
    }
}