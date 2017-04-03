using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Nodes
{
    public class TrieNode<T> : Node<T>
    {
        private TrieNode<T> parent;
        private List<TrieNode<T>> children;
        private char key;

        public TrieNode(T data, char key) : base(data)
        {
            this.key = key;
            this.parent = null;
            this.children = new List<TrieNode<T>>();
        }

        public TrieNode<T> Parent { get { return parent; } set { parent = value; } }
        public char Key { get { return key; } }
        public List<TrieNode<T>> Children { get { return children; } set { children = value; } }

    }
}
