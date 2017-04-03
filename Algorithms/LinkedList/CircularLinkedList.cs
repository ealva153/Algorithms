using Algorithms.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public class CircularLinkedList : ILinkedList<int>
    {
        private LLNode<int> head;
        private LLNode<int> tail;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
        }
        public LLNode<int> Head
        {
            get { return head; }
        }
        public LLNode<int> Tail
        {
            get { return tail; }
        }
        public void Insert(LLNode<int> data)
        {


            if (head == null)
            {
                head = data;
                tail = data;
            }
            else
            {
                data.Next = head;
                tail.Next = data;
                tail = data;

            }
        }

        public bool Remove(LLNode<int> LLNodeToRemove)
        {
            bool removed = false;
            if (head == LLNodeToRemove)
            {
                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                    tail.Next = head;
                }

                removed = true;
            }
            else
            {

                LLNode<int> current;
                current = head;
                while (current.Next != head)
                {
                    if (current.Next == LLNodeToRemove)
                    {
                        if (current.Next == tail)
                        {
                            tail = current;
                            tail.Next = head;
                            removed = true;
                            break;
                        }
                        else
                        {
                            current.Next = current.Next.Next;
                            removed = true;
                            break;
                        }
                    }
                    current = current.Next;

                }
            }

            if (!removed)
            {
                Console.WriteLine("not found");

            }
            return removed;
        }
        public void PrintList()
        {
            LLNode<int> current = head;

            while (true)
            {
                Console.WriteLine(current.Data);
                if (current == tail)
                    break;
                current = current.Next;

            }
        }
    }
}
