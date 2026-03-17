using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAY_1_PRACITCE
{
    internal class Program
    {
        public static int  FindMax(int[] array)
        {
            int max=array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }

            }
            return max;
        }

        public static int EvenNo(int[] array)
        {
            int even_Number = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even_Number++;
                }
            }
            return even_Number;
        }

        public static int[] Reverse(int[] array)
        {
            for(int i = 0; i < array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1-i];
                array[array.Length - 1-i] = temp;
            }
            return array;
        }
        //0,1,1,2,3,5,8,13,21,34,....
        public static void PrintFibonnaci(int limit)
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 0;
            for(int i = 0; i <= limit; i++)
            {
                Console.WriteLine(num1);
                
                sum = num1 + num2;
                num1 = num2;
                num2 = sum; 
                
            }
            
        }
        
        static void Main(string[] args)
        {

            PrintFibonnaci(10);
            Console.WriteLine("Enter the size of the array: ");
            int sizeOfArray=int.Parse(Console.ReadLine());

            int[] array=new int[sizeOfArray];
            for(int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine($"Enter Elment{i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your array is :");
            foreach(int num in array)
            {
                Console.WriteLine(num + " ");
            }
            bool run = true;
            while( run)
            {
                Console.WriteLine("\n1.Find max of the array");
                Console.WriteLine("2.Find the no. of even nummbers in array");
                Console.WriteLine("3.Reverse  your array");
                Console.WriteLine("4.Exit ");

                Console.WriteLine("enter your choice");
                string choice= Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"\n MAX NUMBER:{FindMax(array)}");
                        break;
                    case "2":
                        Console.WriteLine($"Even Count: {EvenNo(array)}");
                        break;
                    case "3":
                        int[] reversed = Reverse(array);                    
                        foreach(int num in reversed)
                        {
                            Console.Write(num + " ");
                        }
                        break;
                    case "4":
                        run=false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }

            }
        }
    }
}
