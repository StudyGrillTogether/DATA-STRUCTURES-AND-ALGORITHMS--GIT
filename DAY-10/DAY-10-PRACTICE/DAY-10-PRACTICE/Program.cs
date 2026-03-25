using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_10_PRACTICE
{
    internal class Program
    {
        static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            else
            {
                int middle=(array.Length) /2;
                int[] left= new int[middle];
                int[] right=new int[array.Length-middle];
                for(int i = 0; i < middle; i++)
                {
                    left[i]=array[i];
                }
                for(int i=middle; i<array.Length; i++)
                {
                    right[i-middle]=array[i];
                }
                left=MergeSort(left);
                right=MergeSort(right);
                return Merge(left, right);
            }
        }
        static int[] Merge(int[] left , int[] right)
        {
            int[] result=new int[left.Length+right.Length];
            int i = 0, j = 0, k = 0;
            while(i<left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    result[k++]=left[i++]; ///take from left
                else
                    result[k++]=right[j++]; //take from right
            }

            //copying remaining elemenents
            while(i<left.Length) result[k++]=left[i++];
            while(j<right.Length) result[k++]=right[j++];

            return result;
        }
        
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 2, 8, 1 };
            int[] sortarray=MergeSort(array);
            foreach(int i in sortarray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
