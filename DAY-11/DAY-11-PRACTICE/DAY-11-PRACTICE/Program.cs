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
            Node root; //points to root node
        }
        static void Main(string[] args)
        {
        }
    }
}
