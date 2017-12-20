using System;
using System.Collections.Generic;

namespace AccessModifiers
{
    internal class Program
    {
        public class Person
        {
            private DateTime _birthdate;

            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }

            public DateTime GetBirthdate()
            {
                return _birthdate;
            }
        }
        public static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1983, 8, 12));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}