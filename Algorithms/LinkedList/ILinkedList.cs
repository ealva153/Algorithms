using Algorithms.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public interface ILinkedList<T>
    {
        void Insert(LLNode<T> data);
        bool Remove(LLNode<T> nodeToRemove);
    }
}
