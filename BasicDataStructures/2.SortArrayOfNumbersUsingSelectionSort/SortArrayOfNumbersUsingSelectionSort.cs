using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SortArrayOfNumbersUsingSelectionSort
{
    class SortArrayOfNumbersUsingSelectionSort
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int min;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int placeholder = arr[i];
                    arr[i] = arr[min];
                    arr[min] = placeholder;
                }
            }

            foreach (var num in arr)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}
