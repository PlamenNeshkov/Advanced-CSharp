using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SequenceInMatrix
{
    class SequenceInMatrix
    {
        static int rows;
        static int cols;

        static List<string> currSeq = new List<string>();
        static List<string> maxSeq = new List<string>();

        static void Main(string[] args)
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    currSeq = CheckRight(matrix, i, j);
                    CheckIfMax();
                    currSeq = CheckDown(matrix, i, j);
                    if (currSeq.Count > maxSeq.Count)
                    CheckIfMax();
                    currSeq = CheckDiag(matrix, i, j);
                    CheckIfMax();
                }
            }

            Console.WriteLine(String.Join(", ", maxSeq));
        }

        static List<string> CheckRight(string[,] matrix, int i, int j)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[i, j]);
            for (int col = j + 1; col < cols; col++)
            {
                if (matrix[i, col] == matrix[i, j])
                {
                    sequence.Add(matrix[i, col]);
                }
                else
                {
                    break;
                }
            }
            return sequence;
        }

        static List<string> CheckDown(string[,] matrix, int i, int j)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[i, j]);
            for (int row = i + 1; row < rows; row++)
            {
                if (matrix[row, j] == matrix[i, j])
                {
                    sequence.Add(matrix[row, j]);
                }
                else
                {
                    break;
                }
            }
            return sequence;
        }

        static List<string> CheckDiag(string[,] matrix, int i, int j)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[i, j]);
            int row = i + 1;
            int col = j + 1;
            while (row < rows && col < cols)
            {
                if (matrix[row, col] == matrix[i, j])
                {
                    sequence.Add(matrix[row, col]);
                    row++;
                    col++;
                }
                else
                {
                    break;
                }
            }
            return sequence;
        }

        static void CheckIfMax()
        {
            if (currSeq.Count > maxSeq.Count)
            {
                maxSeq = currSeq;
            }
        }
    }
}
