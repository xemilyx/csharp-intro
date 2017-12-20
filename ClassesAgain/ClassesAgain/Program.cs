using System;
using System.Collections.Generic;

namespace ClassesAgain
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var p = Person.Parse("John");
            p.Introduce("Mosh");
        }
    }
}