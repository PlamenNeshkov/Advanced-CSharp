using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] first = new int[rows][];
            int[][] second = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                first[i] = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse).ToArray();
            }
            for (int i = 0; i < rows; i++)
            {
                second[i] = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse).ToArray();
                Array.Reverse(second[i]);
            }

            int[][] matched = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matched[i] = first[i].Concat(second[i]).ToArray();
            }

            bool perfectFit = true;
            for (int i = 1; i < rows; i++)
            {
                if (matched[i].Length != matched[i - 1].Length)
                {
                    perfectFit = false;
                }
            }

            if (perfectFit)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine("[{0}]", String.Join(", ", matched[i]));
                }
            }
            else
            {
                int totalCells = 0;
                foreach (var row in matched)
                {
                    totalCells += row.Length;
                }
                Console.WriteLine("The total number of cells is: {0}", totalCells);
            }
        }
    }
}
