using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.LongestIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> longestSeq = new Stack<int>();
            Stack<int> currSeq = new Stack<int>();

            currSeq.Push(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > currSeq.Peek())
                {
                    currSeq.Push(input[i]);
                }
                else
                {
                    if (currSeq.Count > longestSeq.Count)
                    {
                        longestSeq.Clear();
                        foreach (var num in currSeq)
                        {
                            longestSeq.Push(num);
                        }
                    }
                    printStack(currSeq);
                    currSeq.Clear();
                    currSeq.Push(input[i]);
                }
            }
            if (currSeq.Count > longestSeq.Count)
            {
                longestSeq.Clear();
                foreach (var num in currSeq)
                {
                    longestSeq.Push(num);
                }
            }
            printStack(currSeq);
            currSeq.Clear();
            Console.Write("Longest: ");
            foreach (var num in longestSeq)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void printStack(Stack<int> currSeq)
        {
            Stack<int> tempStack = new Stack<int>();
            while (currSeq.Count > 0)
            {
                tempStack.Push(currSeq.Pop());
            }
            foreach (var num in tempStack)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
