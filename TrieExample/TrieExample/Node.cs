using System;
using System.Collections.Generic;

namespace TrieExample
{
    public class Node
    {
        public char Value { get; set; }
        public Node Parent { get; set; }
        public List<Node> Children { get; set; }
        public int DistanceFromRoot { get; set; }

        public Node(char value, Node parent, int distanceFromRoot)
        {
            this.Value = value;
            this.Parent = parent;
            this.Children = new List<Node>();
            this.DistanceFromRoot = distanceFromRoot;
        }

        public Node FindChildNode(char c)
        {
            foreach (var child in Children)
            {
                if (child.Value == c)
                    return child;
            }
            return null;
        }

        public void PrintChildNodes()
        {
            foreach (var child in Children)
            {
                Console.WriteLine("Value: {0}, Parent: {1}, Distance from Root: {2}", child.Value, child.Parent.Value, child.DistanceFromRoot);
            }
        }
    }
}
