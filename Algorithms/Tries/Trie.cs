using Algorithms.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tries
{
    public class Trie
    {
        private TrieNode<int> root;

        public Trie()
        {
            root = new TrieNode<int>(0, '.') { Parent = null };
        }

        private void TrieAdd(string name, int data)
        {
            var currentNode = root;
            var result = currentNode;
            var found = false;
            var j = 0;
            foreach (var c in name)
            {
                found = false;
                foreach (var child in currentNode.Children)
                {
                    if (child.Key == c)
                    {
                        found = true;
                        j++;
                        currentNode = child;
                        break;
                    }
                }
                if (!found)
                    break;
                result = currentNode;
            }
            for (var i = j; i < name.Length; i++)
            {
                var newNode = new TrieNode<int>(0, name[i]) { Parent = result };
                result.Children.Add(newNode);
                result = newNode;
            }

            result.Children.Add(new TrieNode<int>(data, char.MinValue) { Parent = result });
        }

    }
}

