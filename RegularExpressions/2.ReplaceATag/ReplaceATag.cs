using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"<a href=('|"")(.+)\1>(.+)</a>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string replacement = @"[URL href=" + match.Groups[2].Value + "]" + match.Groups[3].Value + "[/URL]";
                text = text.Replace(match.Value, replacement);
            }
            Console.WriteLine(text);

        }
    }
}
