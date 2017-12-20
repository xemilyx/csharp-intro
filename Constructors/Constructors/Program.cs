﻿using System;
using System.Collections.Generic;

namespace Constructors
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1, "John");
            
            var order = new Order();
            customer.Orders.Add(order);
            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}