using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Nodes
{
    public class LLNode<T> : Node<T>
    {
        private LLNode<T> next { get; set; }

        public LLNode(T data) : base(data)
        {
            this.Data = data;
            this.next = null;
        }

        public LLNode<T> Next { get { return next; } set { next = value; } }
    }
}
