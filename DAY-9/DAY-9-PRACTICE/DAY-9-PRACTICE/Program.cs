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
                for (int j = i +1; j < array.Length - 1 - i; j++)
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
         static void Main(string[] args)
        {
            int[] newArray = { 5, 3, 8, 2, 1 };
            int[] n=new int[newArray.Length];
            n=BubbleSort(newArray);
            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
            n = SelectionSort(newArray);
            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
