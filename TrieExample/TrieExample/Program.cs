using System;

namespace TrieExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating a Trie called \"WordsThatStartWithA\".");
            var WordsThatStartWithA = new Trie();
            Console.WriteLine();

            Console.WriteLine("Inserting \"ant\" and \"and\" into \"WordsThatStartWithA\".");
            WordsThatStartWithA.InsertWord("ant");
            WordsThatStartWithA.InsertWord("and");
            Console.WriteLine();

            Console.WriteLine("Printing all words in \"WordsThatStartWithA\":");
            WordsThatStartWithA.PrintWords(WordsThatStartWithA.root, WordsThatStartWithA.root.Value.ToString());
            Console.WriteLine();

            Console.WriteLine("Printing all nodes in \"WordsThatStartWithA\":");
            WordsThatStartWithA.PrintNodes(WordsThatStartWithA.root);

        }
    }
}
