using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_3_GIT_EXERCISE
{
    internal class Program
    {
        static int[] ReverseArray(int[] array)
        {
            for(int i = 0; i < array.Length / 2; i++)
            {
                int temp=array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            return array;
        }
        static int SecondLargest(int[] array)
        {
            int first=int.MinValue;
            int second = int.MinValue;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > first)
                {
                    second = first;
                    first = array[i];
                }
                else if (array[i]>second&& array[i] != first)
                {
                    second = array[i];
                }
            }
            return second;
        }
        static int CountDuplicates(int[] array)
        {
            int duplicates = 0;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j=i+1;j<array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        duplicates++;
                        break;
                    }
                }
            }
            return duplicates;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no.of elemetns in an array: ");
            int sizeOfArray=int.Parse(Console.ReadLine());
            int[] array= new int[sizeOfArray];
            for(int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine($"Enter element: {i+1}");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] newArray=ReverseArray(array);
            Console.Write("The reversed Array is : ");
            for(int i=0;i< newArray.Length; i++)
            {
                Console.Write(newArray[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine($"second largest in array : {SecondLargest(array)}");
            Console.WriteLine($"no. of duplicates in array: {CountDuplicates(array)}");
            //
        }
    }
}
