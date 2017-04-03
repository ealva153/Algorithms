using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Nodes
{
    public class Node<T>
    {
        private T data { get; set; }

        public Node(T data){
            this.data = data;
        }

        public T Data{ get { return data; } set { data = value; } }
    }
}
