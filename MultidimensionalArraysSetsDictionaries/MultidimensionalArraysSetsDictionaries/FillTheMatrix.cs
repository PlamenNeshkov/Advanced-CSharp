using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArraysSetsDictionaries
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrixA = new int[n, n];
            int[,] matrixB = new int[n, n];

            int i = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrixA[row, col] = i;
                    i++;
                }            
            }

            i = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrixB[row, col] = i;
                        i++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrixB[row, col] = i;
                        i++;
                    }
                }
            }

            PrintMatrix(matrixA, n);
            Console.WriteLine();
            PrintMatrix(matrixB, n);
            
        }
    
        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,4} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
