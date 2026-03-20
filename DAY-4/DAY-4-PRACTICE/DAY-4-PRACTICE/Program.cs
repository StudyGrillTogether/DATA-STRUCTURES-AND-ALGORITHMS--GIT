using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_PRACTICE
{
    internal class Program
    {
        class Node
        {
            public int data; //stores value
            public Node next; //points to the next node
        }
        class LinkedList
        {
            Node head; //points to first node

            void AddFirst(int value)
            {
                Node firstNode=new Node();
                firstNode.data = value;
                firstNode.next = head;
                head = firstNode;
                
            }
            /// <summary>
            /// we created the new node using class node
            /// stored the data in it
            /// then pointed that new nodes pointer to the node before we are adding that is head node 
            /// and updated the value of head with new node thus implying that first node is now new node
            /// thus completing the operation of the addfirst method
            /// </summary>
            /// <param name="args"></param>
            void AddLast(int value)
            {
                Node newNode=new Node();
                newNode.data = value;
                newNode.next = null;

                if (head == null)
                {
                    head = newNode;
                    return;
                }
                //traversing the list
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }
            ///in this first we create a new node 
            ///then make the data of it to the value and make its pointer ull since we are adding it to the last
            ///then we check a condition that if the list is empty and if it is we make the newnode head
            ///now we want to update the pointer of current last node so that it points toward our new last node
            ///so to find the current last node we traverse 
            ///we use current as a temporary pointer to traverse the list without losing the head
            ///so we loop using the while loop and find the current last node
            ///then we upadtes it pointer to our new last node that is here new node thus completing the operation
            ///
        }
        
        static void Main(string[] args)
        {

        }
    }
}
