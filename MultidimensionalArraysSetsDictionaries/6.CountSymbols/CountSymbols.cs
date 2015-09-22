using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> occurences = new SortedDictionary<char, int>();

            foreach (var c in input)
            {
                if (occurences.ContainsKey(c))
                {
                    occurences[c]++;
                }
                else
                {
                    occurences[c] = 1;
                }
                
            }
            foreach (var entry in occurences)
            {
                Console.WriteLine("{0}: {1} time/s", entry.Key, entry.Value);
            }
        }
    }
}
