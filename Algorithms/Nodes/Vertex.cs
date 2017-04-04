using Algorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Nodes
{
    public class Vertex<T> : Node<T>
    {
        private List<SinglyLinkedList> neighbors;
        public Vertex(T data) : base(data)
        {

        }
    }
}
