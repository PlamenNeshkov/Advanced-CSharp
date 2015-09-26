using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\w)\1+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                text = text.Replace(match.Value, match.Groups[1].Value);
            }
            Console.WriteLine(text);
        }
    }
}
