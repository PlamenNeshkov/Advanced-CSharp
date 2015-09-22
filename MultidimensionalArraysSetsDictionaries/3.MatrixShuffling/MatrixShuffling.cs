using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            string input;
            do
            {
                input = Console.ReadLine();
                string[] command = input.Split(' ');
                
                if (command[0] == "END")
                {
                    input = "END";
                }
                else if ((command.Length != 5) || (command[0] != "swap")
                     || (int.Parse(command[1]) < 0) || (int.Parse(command[2]) < 0)
                     || (int.Parse(command[3]) > cols) || (int.Parse(command[4]) > rows))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int x1 = int.Parse(command[1]);
                    int y1 = int.Parse(command[2]);
                    int x2 = int.Parse(command[3]);
                    int y2 = int.Parse(command[4]);
                    string placeholder = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = placeholder;
                    PrintMatrix(matrix, rows, cols);
                }
            } while (input != "END");
        }

        static void PrintMatrix(string[,] matrix, int n, int m)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0,4} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
