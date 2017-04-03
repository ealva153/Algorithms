using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Vertex<T>
    {
        
        public T Data { get; set; }
        public LinkedList<Vertex<T>> Neighbors { get; set; }
    }
}
