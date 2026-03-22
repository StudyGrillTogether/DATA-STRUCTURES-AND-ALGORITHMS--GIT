using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DAY_6_GIT_EXERCISE
{
    internal class Program
    {
        class MyQueue
        {
            int[] array; //arrayto store elements
            int front; //index of front element
            int back; //index of back element
            int size; // max size of queue
            int count; //current number of elements
            
            public MyQueue(int size)
            {
                this.size = size;
                this.array=new int[size];
                front = 0; // front starts as 0
                back = -1; //-1 means queues is empty
                count = 0;//track number of elements

            }

            public void Enqueue(int value)
            {
                if (back == size - 1)
                {
                    throw new ArgumentException("The queue is full");
                }
                back++;
                array[back]=value;
                count++;
            }
            ///first we check if the queue is empty or not using bak 
            ///then we increment the back and out the value in the back 
            ///then we increase the count 
            ///
            public int Dequeue()
            {
                if (count==0)
                {
                    throw new ArgumentException("The queue is empty");
                }
                int temp=array[front];
                front++;
                count--;
                return temp;
            }
            /// first we check if the queue is empty or not using count 
            /// then we store the element at front on temp 
            /// then we increment the front here the front acts the same as top in stack 
            /// that is front move the boundary forward and eveerythng before front is ignored 
            /// like top 
            public int Peek()
            {
                if (count == 0)
                {
                    throw new ArgumentException("The queue is empty");
                }
                return array[front];
            }

            public bool IsEmpty()
            {
                return count == 0;
            }

            public void Display()
            {
                if (IsEmpty())
                {
                    throw new ArgumentException("the queue is empty");
                }
                for(int i = front; i < front+count; i++)
                {
                    Console.Write(array[i]+"-"); //we lop like this to only show valid elemets

                }
            }

            
        }

        static void SimulatePrinter(Queue<string> queue)
        {
            while (queue.Count != 0)
            {

                Console.WriteLine($"Printing->{queue.Dequeue()}");
            }

        }
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue(5);

            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. IsEmpty");
            Console.WriteLine("5. Display");
            Console.WriteLine("6. Exit");
            Console.WriteLine("7.Simulate printer Queue: ");

            bool run = true;
            while (run)
            {
                Console.WriteLine("\nEnter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    
                    case "1":
                        Console.WriteLine("Enter value to enqueue: ");
                        int val = int.Parse(Console.ReadLine());
                        queue.Enqueue(val);
                        break;
                    case "2":
                        Console.WriteLine($"Dequeued: {queue.Dequeue()}");
                        break;
                    case "3":
                        Console.WriteLine($"Front element: {queue.Peek()}");
                        break;
                    case "4":
                        Console.WriteLine($"Is Empty: {queue.IsEmpty()}");
                        break;
                    case "5":
                        queue.Display();
                        break;
                    case "6":
                        run = false;
                        break;
                    case "7":
                        Queue<string> printer=new Queue<string>();
                        Console.WriteLine("How many documents to add");
                        int n=int.Parse(Console.ReadLine());
                        for(int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Enter Document{i+1} name: ");
                            string doc=Console.ReadLine();
                            printer.Enqueue(doc);
                        }
                        SimulatePrinter(printer);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }           
        
    }
}
