using System;
using System.Collections.Generic;
using System.IO;

namespace Paths
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var path = @"/Users/emilybrown/coding/C#/HelloWorld/HelloWorld.sln";

            var dotIndex = path.IndexOf(".");
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name w/o ext: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Diectory: " + Path.GetDirectoryName(path));
        }
    }
}