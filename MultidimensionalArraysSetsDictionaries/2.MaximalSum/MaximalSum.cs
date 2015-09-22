using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                int[] currRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = currRow[j];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = -1;
            int maxCol = -1;
            int squareSize = 3;
            for (int row = 0; row <= (n - squareSize); row++)
            {
                for (int col = 0; col <= (m - squareSize); col++)
                {
                    int currSum = 0;
                    for (int i = row; i < row + squareSize; i++)
                    {
                        for (int j = col; j < col + squareSize; j++)
                        {
                            currSum += matrix[i, j];
                        }
                    }
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine("Sum = {0}", maxSum);
            for (int row = maxRow; row < maxRow + squareSize; row++)
            {
                for (int col = maxCol; col < maxCol + squareSize; col++)
                {
                    Console.Write("{0,4} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
