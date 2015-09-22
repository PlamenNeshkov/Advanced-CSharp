using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PythagoreanNumbers
{
    class PythagoreanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums);
            bool any = false;
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if (a < b && (nums[a] * nums[a] + nums[b] * nums[b] == nums[c] * nums[c]))
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", nums[a], nums[b], nums[c]);
                            any = true;
                        }
                    }
                }
            }
            if (!any)
            {
                Console.WriteLine("No");
            }
        }
    }
}
