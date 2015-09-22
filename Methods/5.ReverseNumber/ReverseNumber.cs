using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(GetReversedNumber(num));
        }

        static double GetReversedNumber(double number)
        {
            string strnum = number.ToString();
            string rev = "";
            for (int i = strnum.Length - 1; i >= 0; i--)
            {
                rev += strnum[i];
            }
            return double.Parse(rev);
        }
    }
}
