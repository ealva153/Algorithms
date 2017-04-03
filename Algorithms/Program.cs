using Algorithms.LinkedList;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SinglyLinkedList myList = new SinglyLinkedList();
            var node1 = new Node<int>(6);
            myList.Insert(new Node<int>(5));
            myList.Insert(new Node<int>(2));
            myList.Insert(node1);
            myList.Insert(new Node<int>(1));
            myList.PrintList();
            Console.WriteLine("List after Removal:");
            myList.Remove(node1);
            myList.PrintList();
            Console.WriteLine("----------------");

            SortedLinkedList myList2 = new SortedLinkedList();
            var node2 = new Node<int>(75);
            myList2.Insert(new Node<int>(5));
            myList2.Insert(new Node<int>(2));
            myList2.Insert(new Node<int>(1));
            myList2.Insert(new Node<int>(7));
            myList2.Insert(node2);
            myList2.Insert(new Node<int>(50));
            myList2.Insert(new Node<int>(1000));

            myList2.PrintList();

            myList2.Remove(node2);
            myList2.PrintList();
            Console.WriteLine("----------------");
            CircularLinkedList myList3 = new CircularLinkedList();
            var node3 = new Node<int>(6);
            myList3.Insert(new Node<int>(1));
            myList3.Insert(new Node<int>(2));
            myList3.Insert(node3);
            myList3.Insert(new Node<int>(7));
            //myList3.Insert(node3);

            myList3.PrintList();
            Console.WriteLine("Head is: " + myList3.Head.Data);
            Console.WriteLine("Tail is: " + myList3.Tail.Data);
            Console.WriteLine("Tail.Next is: " + myList3.Tail.Next.Data);
            Console.WriteLine("----------------");

            myList3.Remove(node3);
            myList3.PrintList();
            Console.WriteLine("Head is: " + myList3.Head.Data);
            Console.WriteLine("Tail is: " + myList3.Tail.Data);
            Console.WriteLine("Tail.Next is: " + myList3.Tail.Next.Data);
            Console.WriteLine("----------------");
            Console.ReadLine();
        }
    }
}