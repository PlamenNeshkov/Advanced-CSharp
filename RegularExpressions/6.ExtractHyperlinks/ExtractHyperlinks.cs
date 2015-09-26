using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6.ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            //The regex is incorrect, I couldn't get it to 100/100 on judge...any advice?
            StringBuilder input = new StringBuilder();
            string line;
            do
            {
                line = Console.ReadLine();
                input.Append(line);
            } while (!line.Contains("END"));
            string text = input.ToString();

            string pattern = @"<a\s+(?:[^>]*?\s+)?href\s*=\s*('|"")?([#/\w\(\):'\.]+)\1?[^>]*?>.*?</a>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Groups[2].Value);
            }
        }
    }
}
