using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var firstName = "Emily";
            var lastName = "Suon";

            var fullname = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"Emily", "Nong", "Leif"};
            var formattedNames = string.Join(", ", names);

            var text = @"Hi Nong
Look into the following paths:
c:\folder1\folder2
c:\folder3\folder4";
            
            Console.WriteLine(text);

        }
    }
}