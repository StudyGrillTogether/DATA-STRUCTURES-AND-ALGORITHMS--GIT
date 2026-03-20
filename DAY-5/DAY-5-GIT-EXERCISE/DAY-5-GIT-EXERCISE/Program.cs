using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5_GIT_EXERCISE
{
    internal class Program
    {
        class MyStack
        {
            int[] array;//aray to store elements
            int top; //index of the top element
            int size; //max size of the stack 
            public MyStack(int size)
            {
                this.size = size;
                this.array = new int[size];
                this.top = -1;


            }
            /// <summary>
            /// here we first created an array to store elements then 
            /// intitialized top as the index of top elements 
            /// tjem size as to intialize array so what is its max size
            /// then in constructor we initialized the variables/fields 
            /// size as the size passed when creating an object and array with that size 
            /// and top starting with -1 that is the stack is empty at first
            /// </summary>
            /// <param name="args"></param>
            public void Push(int value)
            {
                if (top == size - 1)
                {
                    throw new ArgumentException("The stack is full");
                }
                top++;
                array[top] = value;
            }
            /// <summary>
            ///  in this we check if the stack is full via if condition 
            ///  then increment top index and store the value in that array index 
            /// </summary>
            /// <returns></returns>
            /// <exception cref="ArgumentException"></exception>
            public int Pop()
            {
                if (top == -1)
                {
                    throw new ArgumentException("the stack is empty");
                }
                int temp = array[top];
                top--;
                return temp;
            }
            /// <summary>
            /// in this we check if the array is empty 
            /// if not we store the top index element in a temp variable
            /// then we decrement the value of top 
            /// point to remember we are not removing the top element just moving the index value 
            /// sp we are just ignoring the pop value since its still in array
            /// since in next push opeartion it will be overwritten
            /// </summary>
            /// <returns></returns>
            /// <exception cref="ArgumentException"></exception>
            public int Peek()
            {
                if (top == -1)
                {
                    throw new ArgumentException("the stack is empty");
                }
                return array[top];
            }
            public bool IsEmpty()
            {
                return top == -1;
            }
            public void Display()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                MyStack temp = new MyStack(size);
                while (!IsEmpty())
                {
                    int val = Pop();
                    Console.WriteLine(val+" ");
                    temp.Push(val);
                }

                //restore orignal stack
                while (!temp.IsEmpty())
                {
                    Push(temp.Pop());
                }
            }
            /// in the display mmethod we create a temp stack then we pop from the orignal 
            /// but while popping in each loop we store it in temp stack 
            /// after the popping and printing is done 
            /// we op form temp stack and push it in the orignal stack 
        }
        
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(5);
            Console.WriteLine("1.enter a new number in stack");
            Console.WriteLine("2.pop from the stack");
            Console.WriteLine("3.peek in the stack");
            Console.WriteLine("4.check of the stack is empty or not");
            Console.WriteLine("5.display stack");
            Console.WriteLine("6.Exit");
            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter your choice:");
                string choice=Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the number you want in stack: ");
                        int num=int.Parse(Console.ReadLine());
                        stack.Push(num);
                        break;
                    case "2":
                        Console.WriteLine($"The number popped is {stack.Pop()}");
                        break;
                    case "3":
                        Console.WriteLine($"THE peeked number from stack is: {stack.Peek()}");
                        break;
                    case "4":
                        Console.WriteLine($"THE stack is empty is: {stack.IsEmpty()}");
                        break;
                    case "5":
                        stack.Display();
                        break;
                        
                    case "6":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;

                }
            }
        }
    }
}
