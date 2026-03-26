using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_11_PRACTICE
{
    internal class Program
    {
        class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }

        class BinaryTree
        {
            public Node root; //points to root node

            public void InOrder(Node node)
            {
                if (node == null) return;
                InOrder(node.left); //go left
                Console.Write(node.data+" "); //print
                InOrder(node.right);//go right
            }

            public void PreOrder(Node node)
            {
                if (node == null) return;
                Console.Write(node.data+" ");
                PreOrder(node.left);
                PreOrder(node.right);
            }

            public void PostOrder(Node node)
            {
                if (node == null) return;
                PostOrder(node.left);
                PostOrder(node.right);
                Console.Write(node.data+" ");
            }
        }

        
        static void Main(string[] args)
        {
            BinaryTree tree= new BinaryTree();
            tree.root=new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Inorder:");
            tree.InOrder(tree.root);

            Console.WriteLine();
            Console.WriteLine("Preorder:");
            tree.PreOrder(tree.root);

            Console.WriteLine() ;
            Console.WriteLine("Postorder:");
            tree.PostOrder(tree.root);

        }
    }
}
