using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBBinarySearchTree
{
    class BST
    {
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
            Console.ReadKey();

        }
    }
}
