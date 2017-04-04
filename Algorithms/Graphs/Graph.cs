using Algorithms.LinkedList;
using Algorithms.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class Graph<T>
    {
        private int[] visited;
        private int v;
        private List<LinkedList<int>> neighbors;
        public Graph(int V)
        {
            v = V;
            visited = new int[v];
            neighbors = new List<LinkedList<int>>();
            for (int i = 0; i < V; i++)
            {
                neighbors.Add(new LinkedList<int>());
            }

        }

        public void AddEdge(int index, int neighbor)
        {
            neighbors[index].AddLast(new LinkedListNode<int>(neighbor));
        }
        public void BreadthFirstSearch(int source)
        {
            int[] visited = new int[v];

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                visited[vertex] = 1;
                Console.WriteLine(vertex);

                foreach (var node in neighbors[vertex])
                {
                    if (!(visited[node] == 1))
                    {
                        queue.Enqueue(node);
                    }
                }
            }


        }


        public void CleanVisited()
        {
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = 0;
            }
        }
        public void DepthFirstSearchRec(int source)
        {
            Console.WriteLine(source);
            visited[source] = 1;

            foreach (var node in neighbors[source])
            {
                if (!(visited[node] == 1))
                {
                    DepthFirstSearchRec(node);
                }
            }
        }
        public void DepthFirstSearch(int source)
        {
            int[] visited = new int[v];
            Stack<int> stack = new Stack<int>();
            stack.Push(source);
            while (stack.Count > 0)
            {
                int vertex = stack.Pop();
                visited[vertex] = 1;
                Console.WriteLine(vertex);

                foreach (var node in neighbors[vertex])
                {
                    if (!(visited[node] == 1))
                    {
                        stack.Push(node);
                    }
                }

            }


        }
    }
}
