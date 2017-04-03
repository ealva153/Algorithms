using Algorithms.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public class SinglyLinkedList : ILinkedList<int>
    {
        private LLNode<int> head;
        public SinglyLinkedList()
        {
            head = null;
        }
        public void Insert(LLNode<int> data)
        {


            if (head == null)
            {
                head = data;
            }
            else
            {
                if (head.Next == null)
                {
                    head.Next = data;
                }
                else
                {
                    LLNode<int> current;
                    current = head.Next;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = data;
                }
            }
        }

        public bool Remove(LLNode<int> LLNodeToRemove)
        {
            bool removed = false;
            if (head == LLNodeToRemove)
            {
                if (head.Next != null)
                    head = head.Next;
                else
                    head = null;

                removed = true;
            }
            else
            {
                if (head.Next == LLNodeToRemove)
                {
                    if (head.Next.Next != null)
                        head.Next = head.Next.Next;
                    else
                        head.Next = null;

                    removed = true;
                }
                else
                {
                    LLNode<int> current;
                    current = head.Next;
                    while (current.Next != null)
                    {
                        if (current.Next == LLNodeToRemove)
                        {
                            if (current.Next.Next != null)
                                current.Next = current.Next.Next;
                            else
                                current.Next = null;
                            removed = true;
                        }
                        current = current.Next;

                    }
                }
            }
            if(!removed)
            {
                Console.WriteLine("not found");

            }
            return removed;
        }
        public void PrintList()
        {
            LLNode<int> current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
