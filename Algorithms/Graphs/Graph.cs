using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class Graph<T>
    {
        private List<Vertex<T>> Vertices;
        public Graph(int V)
        {
            Vertices = new List<Vertex<T>>(V);
   
        }

        public void Add(int index,Vertex<T> neighbor)
        {
            Vertices[index].Neighbors.AddLast(neighbor);
        }
        public void BreadthFirstSearch(int source)
        {
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();


        }
    }
}
