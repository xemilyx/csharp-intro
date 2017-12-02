using System;
using System.Collections.Generic;

namespace Section5Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("User entered " + number1);

            Console.ReadLine();
            
            Console.Write("Enter a number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine("User entered " + number2);

            var larger = Compare(number1, number2);

            Console.WriteLine(larger);

            //Console.WriteLine(String.Format("User entered {0} and {1}", number1, number2));

        }

        public static int Compare(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
                return 0;
        }
    }
}