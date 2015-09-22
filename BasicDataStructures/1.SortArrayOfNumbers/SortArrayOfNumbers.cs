using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(arr);
            foreach (var num in arr)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}
