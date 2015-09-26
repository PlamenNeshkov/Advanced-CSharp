using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=[\s\(\)\/\\]|^)[A-Za-z][\w]{2,24}(?=[\s\(\)\/\\]|$)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            int maxSum = int.MinValue;
            int maxIndex = -1;
            for (int i = 1; i < matches.Count; i++)
            {
                int sum = matches[i - 1].Value.Length + matches[i].Value.Length;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIndex = i - 1;
                }
            }
            for (int i = maxIndex; i <= maxIndex + 1; i++)
            {
                Console.WriteLine(matches[i].Value);
            }
        }
    }
}
