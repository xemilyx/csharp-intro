using System;
using System.Collections.Generic;
using System.Text;

namespace SummarizingText
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sentence = "This is going to be a really, really, really, really, really, really long text.";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);

            var builder = new StringBuilder("Hello World");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);

            Console.WriteLine("First char:" + builder[0]);
            
        }

        
    }
}