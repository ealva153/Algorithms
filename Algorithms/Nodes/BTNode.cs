using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Nodes
{
    public class BTNode<T> : Node<T>
    {
        private BTNode<T> left;
        private BTNode<T> right;

        public BTNode(T data) :base(data)
        {
            left = null;
            right = null;
        }

        public BTNode<T> Left { get { return this.left; } set { left = value; } }
        public BTNode<T> Right { get { return this.right; } set { right = value; } }


    }
}
