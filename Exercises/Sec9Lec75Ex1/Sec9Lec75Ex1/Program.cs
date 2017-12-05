using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace Sec9Lec75Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var path = @"/Users/emilybrown/coding/C#/poem.txt";

            var fileText = File.ReadAllText(path);

            var wordList = ConvertPoemToWordList(fileText);

            Console.WriteLine("Number of words in file: " + wordList.Count);

            Console.WriteLine("Longest word: " + FindLongestWord(wordList));
        }

        public static List<string> ConvertPoemToWordList(string poem)
        {
            var lineList = new List<string>(poem.Split('\n'));
            
            var wordList = new List<string>();

            foreach (var line in lineList)
            {
                var words = line.Split(' ');
                foreach (var word in words)
                {
                    if (!(word.Contains("–") && word.Length == 1) && !String.IsNullOrWhiteSpace(word))
                    {
                        if (Char.IsPunctuation(word[word.Length-1]))
                            wordList.Add(word.Substring(0,word.Length-1));
                        else
                        {
                            wordList.Add(word);
                        }
                    }
                }
            }
            return wordList;
        }
        
        public static string FindLongestWord(List<string> words)
        {
            var longestWord = "";
            foreach (var word in words)
            {
                //you could have multiple words of the same length, so my program takes the last longest word
                if (word.Length >= longestWord.Length)
                    longestWord = word;
            }
            return longestWord;
        }
    }
    
}