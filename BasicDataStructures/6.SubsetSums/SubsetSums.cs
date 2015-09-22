using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SubsetSums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

            bool flag = false;
            int possibleSubsets = (int)Math.Pow(2, arr.Length);
            for (int mask = 0; mask <= possibleSubsets; mask++)
            {
                Stack<int> subset = new Stack<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        subset.Push(arr[i]);
                    }
                }
                if (subset.Sum() == n && subset.Count != 0)
                {
                    Console.WriteLine(String.Join(" + ", subset) + " = " + n);
                    flag = true;
                }
                subset.Clear();
            }
            if (!flag)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}
