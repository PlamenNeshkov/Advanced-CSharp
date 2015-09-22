using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CategorizeNumbers
{
    class CategorizeNumbers
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            List<int> roundNums = new List<int>();
            List<double> decimalNums = new List<double>();

            foreach(var num in arr)
            {
                if (num % 1 == 0)
                {
                    roundNums.Add((int)num);
                }
                else
                {
                    decimalNums.Add(num);
                }
            }

            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", 
                              String.Join(", ", decimalNums), decimalNums.Min(), decimalNums.Max(), decimalNums.Sum(), decimalNums.Average());
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", 
                              String.Join(", ", roundNums), roundNums.Min(), roundNums.Max(), roundNums.Sum(), roundNums.Average());
            
        }
    }
}
