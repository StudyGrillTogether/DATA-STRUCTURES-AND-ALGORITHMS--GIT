using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5_PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            //pushing element
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            //peek-see top element
            Console.WriteLine(stack.Peek());

            //pop-remove top element
            Console.WriteLine(stack.Pop()); //5
            stack.Push(5);

            //IsEmpty checks if empty
            Console.WriteLine(stack.Count==0); //false

            //popping all elements
            while(stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
