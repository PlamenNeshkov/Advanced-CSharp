using System;
using System.Linq;

namespace InsertionSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			for (int i = 1; i < numbers.Length; i++)
			{
				int j = i;
				while ((j > 0) && (numbers[j - 1] > numbers[j]))
				{
					int placeholder = numbers[j];
					numbers[j] = numbers[j - 1];
					numbers[j - 1] = placeholder;
					j--;
				}
			}
			foreach (var num in numbers) 
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine();
		}
	}
}
