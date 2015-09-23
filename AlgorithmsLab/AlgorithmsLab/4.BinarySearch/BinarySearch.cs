using System;
using System.Linq;

namespace BinarySearch
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int n = int.Parse(Console.ReadLine());
			//Console.WriteLine(LinearSearch(nums, n));
			Array.Sort(nums);
			nums = nums.Distinct().ToArray();
			Console.WriteLine(BinarySearch(nums, n, 0, nums.Length - 1));
		}

		static int LinearSearch(int[] arr, int elem)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == elem)
				{
					return i;
				}
			}
			return -1;
		}

		static int BinarySearch (int[] arr, int elem, int min, int max)
		{
			int mid = (min + max) / 2;
			if (min > max) 
			{
				return -1;
			} 
			else if (elem == arr[mid]) 
			{
				return mid;
			} 
			else if (elem > arr[mid]) 
			{
				min = mid + 1;
				return BinarySearch(arr, elem, min, max);
			}
			else //if (elem < arr[mid]) 
			{
				max = mid - 1;
				return BinarySearch(arr, elem, min, max);
			} 
		}
	}
}
