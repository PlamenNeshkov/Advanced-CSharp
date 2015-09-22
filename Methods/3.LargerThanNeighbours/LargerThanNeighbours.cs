using System;
using System.Linq;

namespace LargerThanNeighbours
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(IsLargerThanNeighbours(numbers, i));
			}
		}

		static bool IsLargerThanNeighbours (int[] numbers, int i)
		{
            bool largerThanPrev = false;
            if (i - 1 >= 0)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    largerThanPrev = true;
                }
            }
            else
            {
                largerThanPrev = true;
            }
            bool largerThanNext = false;
            if (i + 1 < numbers.Length)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    largerThanNext = true;
                }
            }
            else
            {
                largerThanNext = true;
            }
            return largerThanPrev && largerThanNext;
        }
	}
}
