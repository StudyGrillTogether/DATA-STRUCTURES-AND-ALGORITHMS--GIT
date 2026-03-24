using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DAY_9_PRACTICE
{
    internal class Program
    {
        public static int[] BubbleSort(int[] array)
        {
            
            for(int i=0; i<array.Length; i++)
            {
                for(int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                    
                }
                
            }
            return array;
        }
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i +1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp=array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;

            }
            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while(j>=0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            return array;
        }
         static void Main(string[] args)
        {
            int[] arr1 = { 5, 3, 8, 2, 1 };
            int[] arr2 = { 5, 3, 8, 2, 1 };
            int[] arr3 = { 5, 3, 8, 2, 1 };

            BubbleSort(arr1);
            SelectionSort(arr2);
            InsertionSort(arr3);

            Console.Write("Bubble Sort:    ");
            foreach (int i in arr1) Console.Write(i + " ");

            Console.Write("\nSelection Sort: ");
            foreach (int i in arr2) Console.Write(i + " ");

            Console.Write("\nInsertion Sort: ");
            foreach (int i in arr3) Console.Write(i + " ");
        }
    }
}
