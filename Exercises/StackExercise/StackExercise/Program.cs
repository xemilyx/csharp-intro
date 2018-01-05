using System;
using System.Collections.Generic;

namespace StackExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push("super");
            stack.Push("cala");
            stack.Push("fragalistic");

            stack.Items.ForEach(Console.WriteLine);

            //stack.Push(null);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //stack.Clear();
            stack.Items.ForEach(Console.WriteLine);
        }
    }
}
