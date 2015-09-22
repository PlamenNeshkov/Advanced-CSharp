using System;
using System.Linq;

namespace FirstLargerThanNeighbours
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool anyLargerNum = false;
            int indexOfFirstLargerNum = -1;

            int i = 0;
            while (!anyLargerNum && (i < numbers.Length))
            {
                if (IsLargerThanNeighbours(numbers, i))
                {
                    anyLargerNum = true;
                    indexOfFirstLargerNum = i;
                }
                i++;
            }

            Console.WriteLine(indexOfFirstLargerNum);
        }

        static bool IsLargerThanNeighbours(int[] numbers, int i)
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
