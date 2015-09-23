using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _7.GenericArraySort
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
        }

        static double Mininmum(double[] numbers)
        {
            double min = double.MaxValue;
            foreach (var num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        static decimal Mininmum(decimal[] numbers)
        {
            decimal min = decimal.MaxValue;
            foreach (var num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        static double Maximum(double[] numbers)
        {
            double max = double.MinValue;
            foreach (var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        static decimal Maximum(decimal[] numbers)
        {
            decimal max = decimal.MinValue;
            foreach (var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        static double Sum(double[] numbers)
        {
            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static decimal Sum(decimal[] numbers)
        {
            decimal sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        
        static double Average(double[] numbers)
        {
            return Sum(numbers) / numbers.Length;
        }

        static decimal Average(decimal[] numbers)
        {
            return Sum(numbers) / numbers.Length;
        }

        static double Product(double[] numbers)
        {
            double product = 1;
            foreach (var num in numbers)
            {
                product *= num;
            }
            return product;
        }

        static decimal Product(decimal[] numbers)
        {
            decimal product = 1;
            foreach (var num in numbers)
            {
                product *= num;
            }
            return product;
        }
    }
}
