using Counting_Sort;
using System;
using System.Collections.Generic;

namespace OrdinamentoCountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TANTI = 20;
            Random r = new Random();
            int[] array = new int[TANTI];
            List<int> numeri = new List<int>();
            for (int i = 0; i < TANTI; i++)
            {
                int k;
                do
                {
                    k = r.Next(0, 100);
                } while (numeri.Contains(k));
                numeri.Add(k);
                array[i] = k;
            }
            Console.WriteLine("STAMPO ARRAY NON ORDINATO: ");
            for(int i = 0; i< array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            int[] sortedArray = CountingSort.Counting_Sort(array);
            Console.WriteLine("STAMPO ARRAY ORDINATO: ");
            for (int i = 0; i < TANTI; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
        }
    }
}
