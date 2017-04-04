using Algorithms.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trees
{
    public class BinarySearchTree
    {
        private BTNode<int> root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int add)
        {
            BTNode<int> toAdd = new BTNode<int>(add);
            
            if(root == null)
            {
                root = toAdd;
            }

            else
            {
                var current = root;
                BTNode<int> parent = null;
                while(true)
                {
                    if(toAdd.Data < current.Data)
                    {
                        parent = current;
                        current = current.Left;
                        if(current == null)
                        {
                            parent.Left = toAdd;
                            break;
                        }
                    }
                    else if(toAdd.Data > current.Data)
                    {
                        parent = current;
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = toAdd;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                   
                }

            }
        }
        public void PrintInOrder()
        {
            PrintInOrder(this.root);
        }
        public void PrintPreOrder()
        {
            PrintPreOrder(this.root);
        }
        public void PrintPostOrder()
        {
            PrintPostOrder(this.root);
        }
        private void PrintInOrder(BTNode<int> root)
        {
            if(root == null)
            {
                return;
            }

            PrintInOrder(root.Left);

            Console.WriteLine(root.Data);

            PrintInOrder(root.Right);
        }
        private void PrintPreOrder(BTNode<int> root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.Data);
            PrintPreOrder(root.Left);
            PrintPreOrder(root.Right);
        }
        private void PrintPostOrder(BTNode<int> root)
        {
            if (root == null)
            {
                return;
            }

            PrintInOrder(root.Left);
            PrintInOrder(root.Right);
            Console.WriteLine(root.Data);
        }
    }
}
