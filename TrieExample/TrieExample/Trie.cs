using System;
namespace TrieExample
{
    public class Trie
    {
        public readonly Node root;

        public Trie()
        {
            root = new Node('^', null, 0);
        }

        public void InsertWord(string word)
        {
            var currentNode = root;
            var distance = 1;

            foreach (var letter in word)
            {
                if (currentNode.FindChildNode(letter) == null)
                {
                    currentNode.Children.Add(new Node(letter, currentNode, distance));
                }
                currentNode = currentNode.FindChildNode(letter);
                distance++;
            }
            currentNode.Children.Add(new Node('$', currentNode, distance));
        }

        public void PrintNodes(Node node)
        {
            if (node.Children == null || node.Children.Count == 0)
            {
                return;
            }
            else
            {
                node.PrintChildNodes();
                foreach (var child in node.Children)
                {
                    PrintNodes(child);
                }
            }

        
        }

        public void PrintWords(Node node, string result)
        {
            if (node.Children == null || node.Children.Count == 0)
            {
                Console.WriteLine(result);
                return;
            }
            else 
            {
                foreach (var child in node.Children)
                {
                    PrintWords(child, result + child.Value.ToString());
                }
            }
        }
    }
}
