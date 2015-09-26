using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4.SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = @"[A-Z][\w\s]+?" + keyword + @"[\w\s]+?[\.!\?]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
