using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Conditionals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                    case Season.Autumn:
                    case Season.Summer:
                        Console.WriteLine("We have a promotion!");
                        break;
                        
                    default:
                        Console.WriteLine("I don't understand this season!");
                        break;
            }

        }
    }
}