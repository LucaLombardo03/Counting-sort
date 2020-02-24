using System;

namespace Counting_Sort
{
    public class CountingSort
    {
        public static int[] Counting_Sort(int[]array)
        {
            int[] sortedArray = new int[array.Length];
            int[] minori = new int[array.Length];
            
            for(int i = 0; i < array.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        c++;
                    }
                }
                minori[i] = c;
            }
            for(int i = 0; i < array.Length; i++)
            {
                sortedArray[minori[i]] = array[i];
            }
            return sortedArray;
        }
    }
}


