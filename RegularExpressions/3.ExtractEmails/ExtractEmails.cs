using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"[A-Za-z\d][\w\d-\.]*[A-Za-z\d]@([A-Za-z-]+\.)+[A-Za-z-]+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
