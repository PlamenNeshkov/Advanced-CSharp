using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.StuckNumbers
{
    class StuckNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

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
                                string ab = "" + a + b;
                                string cd = "" + c + d;
                                if (ab == cd)
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
