using System;
using System.Collections.Generic;
using System.IO;

namespace Directories
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Directory.CreateDirectory(@"/Users/emilybrown/coding/folder1");

/*            var files = Directory.GetFiles(@"/Users/emilybrown/coding/", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);*/

            var directories =
                Directory.GetDirectories(@"/Users/emilybrown/coding/", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);
                
        }
    }
}