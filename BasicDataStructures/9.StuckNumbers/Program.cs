using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.StuckNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool any = false;
            int numslen = numbers.Length;
            for (int n1 = 0; n1 < numslen; n1++)
            {
                for (int n2 = 0; n2 < numslen; n2++)
                {
                    for (int n3 = 0; n3 < numslen; n3++)
                    {
                        for (int n4 = 0; n4 < numslen; n4++)
                        {
                            int a = numbers[n1];
                            int b = numbers[n2];
                            int c = numbers[n3];
                            int d = numbers[n4];

                            if (a != b && a != c && a != d && b != c && b != d && c != d)
                            {
                                StringBuilder ab = new StringBuilder();
                                ab.Append(a);
                                ab.Append(b);
                                StringBuilder cd = new StringBuilder();
                                cd.Append(c);
                                cd.Append(d);
                                if (ab.ToString() == cd.ToString())
                                {
                                    Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                                    any = true;
                                }
                            }
                        }
                    }
                }
            }
            if (any == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
