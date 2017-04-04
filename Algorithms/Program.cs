using Algorithms.Graphs;
using Algorithms.LinkedList;
using Algorithms.Nodes;
using Algorithms.Trees;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //SinglyLinkedList myList = new SinglyLinkedList();
            //var node1 = new LLNode<int>(6);
            //myList.Insert(new LLNode<int>(5));
            //myList.Insert(new LLNode<int>(2));
            //myList.Insert(node1);
            //myList.Insert(new LLNode<int>(1));
            //myList.PrintList();
            //Console.WriteLine("List after Removal:");
            //myList.Remove(node1);
            //myList.PrintList();
            //Console.WriteLine("----------------");

            //SortedLinkedList myList2 = new SortedLinkedList();
            //var node2 = new LLNode<int>(75);
            //myList2.Insert(new LLNode<int>(5));
            //myList2.Insert(new LLNode<int>(2));
            //myList2.Insert(new LLNode<int>(1));
            //myList2.Insert(new LLNode<int>(7));
            //myList2.Insert(node2);
            //myList2.Insert(new LLNode<int>(50));
            //myList2.Insert(new LLNode<int>(1000));

            //myList2.PrintList();

            //myList2.Remove(node2);
            //myList2.PrintList();
            //Console.WriteLine("----------------");
            //CircularLinkedList myList3 = new CircularLinkedList();
            //var node3 = new LLNode<int>(6);
            //myList3.Insert(new LLNode<int>(1));
            //myList3.Insert(new LLNode<int>(2));
            //myList3.Insert(node3);
            //myList3.Insert(new LLNode<int>(7));
            ////myList3.Insert(node3);

            //myList3.PrintList();
            //Console.WriteLine("Head is: " + myList3.Head.Data);
            //Console.WriteLine("Tail is: " + myList3.Tail.Data);
            //Console.WriteLine("Tail.Next is: " + myList3.Tail.Next.Data);
            //Console.WriteLine("----------------");

            //myList3.Remove(node3);
            //myList3.PrintList();
            //Console.WriteLine("Head is: " + myList3.Head.Data);
            //Console.WriteLine("Tail is: " + myList3.Tail.Data);
            //Console.WriteLine("Tail.Next is: " + myList3.Tail.Next.Data);
            //Console.WriteLine("----------------");
            //Console.ReadLine();



            //BinarySearchTree bst = new BinarySearchTree();
            //bst.Insert(8);
            //bst.Insert(3);
            //bst.Insert(10);
            //bst.Insert(1);
            //bst.Insert(10);
            //bst.Insert(14);

            //bst.PrintInOrder();
            //Console.WriteLine("---------------");
            //bst.PrintPreOrder();
            //Console.WriteLine("---------------");
            //bst.PrintPostOrder();
            //Console.ReadLine();


            Graph<int> g = new Graph<int>(4);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            g.BreadthFirstSearch(2);
            Console.WriteLine("---------------");
            g.DepthFirstSearch(2);
            Console.WriteLine("---------------");
            g.DepthFirstSearchRec(2);

            Console.ReadLine();
        }
    }
}