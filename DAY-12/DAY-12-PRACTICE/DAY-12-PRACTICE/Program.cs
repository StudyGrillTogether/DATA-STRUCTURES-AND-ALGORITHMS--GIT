using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_12_PRACTICE
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
            public Node root;

            public void Insert(int value)
            {
                root=InsertRecursive(root, value);
            }

            private Node InsertRecursive(Node node,int value)
            {
                if (node == null)
                {
                    return new Node(value);
                }
                else if (value < node.data)
                {
                   node.left=InsertRecursive(node.left,value); //GOING LEFT
                    
                }
                else
                {
                    node.right=InsertRecursive(node.right,value);
                }

                return node;
            }

            public bool BSTSearch(int value)
            {
                return SearchRecursive(root, value);
            }

            private bool SearchRecursive(Node node,int value)
            {
                if (node == null)
                {
                    return false;
                }
                else if (value == node.data)
                {
                    return true;
                }
                else  if(value<node.data)
                {
                   return SearchRecursive(node.left,value);
                }
                else
                {
                    return SearchRecursive(node.right,value);
                }

            }
        }
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(8);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(9);

            Console.WriteLine(tree.BSTSearch(6));
            Console.WriteLine(tree.BSTSearch(7));

            Dictionary<string,int> dict = new Dictionary<string,int>();
            dict["john"] = 25;
            dict["jane"] = 30;

            //search
            Console.WriteLine(dict["john"]);

            //check if key exisxts

            Console.WriteLine(dict.ContainsKey("john")); //true

            //delete
            dict.Remove("john");

            foreach(var i in dict.Keys)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
