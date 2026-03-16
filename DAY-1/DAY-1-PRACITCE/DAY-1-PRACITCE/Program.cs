using System;
using System.Collections.Generic;
using System.Linq;
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
        static void Main(string[] args)
        {

        }
    }
}
