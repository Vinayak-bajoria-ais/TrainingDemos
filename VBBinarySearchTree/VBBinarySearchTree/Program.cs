﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBBinarySearchTree
{
    class BST
    {
        public static int num;
        public static int leftnum=-1;
        public static int rightnum=-1;
        int data;
        BST left;
        BST right;
        BST parent;

        BST root= null;

        public void inserting_node(int data)
        {
            BST newnode = new BST();
            newnode.data = data;
            newnode.left = null;
            newnode.right = null;

            if(root== null)
            {
                root = newnode;
                return;
            }

            BST currentnode= null;
            BST parentptr= null;
            currentnode = root;
            while(currentnode != null)
            {
                parentptr = currentnode;
                if(data < currentnode.data)
                {
                    currentnode = currentnode.left;
                }
                else
                {
                    currentnode = currentnode.right;
                }
            }
            
                if (data < parentptr.data)
            {
                parentptr.left = newnode;
                newnode.parent = parentptr;
            }
            else
            {
                parentptr.right = newnode;
                newnode.parent = parentptr;
            }
            return;
        }

        public void traversing_options()
        {
            if(root== null)
            {
                Console.WriteLine("the tree is empty, enter something first");
                return;
            }
            else
            {
                Console.WriteLine(" we are traversing tree in all possible manners");
                Console.WriteLine("this is inorder traversal");
                inorder_traversal(root);
                Console.WriteLine("this is preorder traversal");
                preorder_traversal(root);
                Console.WriteLine("this is postorder traversal");
                postorder_traversal(root);

            }
        }

        public void inorder_traversal(BST root)
        {
            if(root!= null)
            {
                inorder_traversal(root.left);
                Console.WriteLine("value= " + root.data);
                inorder_traversal(root.right);
            }
        }

        public void preorder_traversal(BST root)
        {
            if (root != null)
            {
                Console.WriteLine("value= " + root.data);
                preorder_traversal(root.left);
                preorder_traversal(root.right);
            }
        }

        public void postorder_traversal(BST root)
        {
            if (root != null)
            {
                postorder_traversal(root.left);
                postorder_traversal(root.right);
                Console.WriteLine("value= " + root.data);
            }
        }


        public void BFS()
        {
            Console.WriteLine("this is BFS");
            Queue bfsq = new Queue();
            bfsq.Enqueue(root.data);
            num = bfsq.Dequeue();
            
            while(Queue.flag != true)
            {
                
                Tree_search_inorder(root);
                if (leftnum != -1)
                {
                    bfsq.Enqueue(leftnum);
                }
                
                if(rightnum != -1)
                {
                    bfsq.Enqueue(rightnum);
                }
                //Console.WriteLine("the queue befre deletion");
                bfsq.Display();
                num = bfsq.Dequeue();
                //Console.WriteLine("the queue afeter deletion");
               // bfsq.Display();
                
            }

        }

        public void Tree_search_inorder(BST iterator)
        {
            if(iterator!= null)
            {
                Tree_search_inorder(iterator.left);
                if (iterator.data == num)
                {
                    if (iterator.left != null)
                    {
                        leftnum = iterator.left.data;
                    }
                    else
                    {
                        leftnum = -1;
                    }
                    if (iterator.right != null)
                    {
                        rightnum = iterator.right.data;
                    }
                    else
                    {
                        rightnum = -1;
                    }
                    return;
                }
                Tree_search_inorder(iterator.right);

            }
        }

        

    }

    class Queue
    {
        public static bool flag = false;
        int data;
        Queue next;

        Queue start = null;

        public void Enqueue(int data)
        {
            Queue newnode = new Queue();
            newnode.next = null;
            newnode.data = data;
            if(start== null)
            {
                start = newnode;
                return;
            }
            else
            {
                Queue iterator = start;
                while(iterator.next!= null)
                {
                    iterator = iterator.next;
                }
                iterator.next = newnode;
                newnode.next = null;
                return;
            }
        }

        public int Dequeue()
        {
            if(start== null)
            {
               // Console.WriteLine("the queue is empty");
                flag = true;
                return -1;
            }
            else
            {
                Queue deletionnode = start;
                start = start.next;
                deletionnode.next = null;
                //Console.WriteLine("value being deleted= " + deletionnode.data);
                return deletionnode.data;
            }
        }

        public void Display()
        {
            if(start== null)
            {
               // Console.WriteLine("the queue is empty");
            }
            else
            {
                Queue iterator = start;
                while(iterator.next!= null)
                {
                    Console.Write("value= " + iterator.data + "\t");
                    iterator = iterator.next;
                }
                Console.Write("value= " + iterator.data + "\t");
                return;
            }
        }


    }

    class Example
    {
        static void Main(string[] args)
        {
            BST bst1 = new BST();
            bst1.traversing_options();
            bst1.inserting_node(5);
            bst1.inserting_node(7);
            bst1.inserting_node(8);
            bst1.inserting_node(9);
            bst1.inserting_node(14);
            bst1.inserting_node(2);
            bst1.inserting_node(3);
            bst1.traversing_options();
            bst1.BFS();
            Console.ReadKey();

        }
    }
}
