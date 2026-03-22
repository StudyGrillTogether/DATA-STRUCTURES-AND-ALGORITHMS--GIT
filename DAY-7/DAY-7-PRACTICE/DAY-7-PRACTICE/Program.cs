using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_PRACTICE
{
    internal class Program
    {
        static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }

        public static void PrintFibonnaci(int limit)
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 0;
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(num1);
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }
        }//this is in normal way wihout using recurrsion

        public static int Fibonnaci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonnaci(n - 1) + Fibonnaci(n - 2);
            }
        }
        /// <summary>
        /// here we use the concept that fib(3)=fib(2)+fib(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfNumbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + SumOfNumbers(n - 1);
        }

        //using dynamic programming
        static int[] memo = new int[100];
        static int FibonnaciDynamic(int n)
        {
            
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            if (memo[n] != 0) //already calculated
                return memo[n]; //return stored result
            memo[n] = FibonnaciDynamic(n - 1) + FibonnaciDynamic(n - 2); //stored resuly
            return memo[n];
        }
        //fibbonaci using dynamic programming-memoziation approach
        /// <summary>
        /// here we use the top to bottom approach 
        /// here we take a array empty
        /// then we we see if for that n in that array we calculated a value if yes we load it up
        /// instead of doing it again thus making O(n)
        /// and if not calculated we procced to lower cases thus obtaining the calculated values
        /// </summary>
        /// <param name="args"></param>
        static int FibTabluation(int n)
        {
            if(n == 0) return 0;
            if (n == 1) return 1;
            int[] table = new int[n + 1];

            table[0] = 0; //fib(0)==0
            table[1] = 1; //fib(1)==1 base cases

            for (int i = 2; i <= n; i++)
            {
                table[i] = table[i - 1] + table[i - 2]; //using already stored values
            }
            return table[n];
        }
        /// <summary>
        /// using bottom to top approach that is dynamic-tabulation method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(3));

            Console.WriteLine("eneter the number you want fibonnaci of : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Fibonnaci(i));
            }

            Console.WriteLine($"the sum of n=6 numbers is :{SumOfNumbers(6)}");

            Console.WriteLine("using dynamic programming-memoization");
            for (int i = 0; i <= n; i++)
            {
                Console.Write(FibonnaciDynamic(i) + " ");
            }
            Console.WriteLine("using tabulation approach");
            Console.WriteLine();

            for (int i = 0; i <= n; i++)
            {
                Console.Write(FibTabluation(i)+" ");
            }

        }
    }
}
