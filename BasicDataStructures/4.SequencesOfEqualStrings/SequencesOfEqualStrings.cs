using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Queue<string> buffer = new Queue<string>();
            foreach (var word in input)
            {
                buffer.Enqueue(word);
            }
            string prev = buffer.Dequeue();
            Console.Write(prev + " ");
            while (buffer.Count > 0)
            {
                string curr = buffer.Dequeue();
                if (prev != curr)
                {
                    Console.WriteLine();
                }
                Console.Write(curr + " ");
                prev = curr;
            }
            Console.WriteLine();
        }
    }
}
