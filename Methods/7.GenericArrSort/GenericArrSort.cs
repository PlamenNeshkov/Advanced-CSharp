using System;

namespace GenericArrSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
			string[] strings = { "zaz", "cba", "baa", "azis"};
			DateTime[] dates = 
			{
			 new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1)
			};

			numbers = SortArray(numbers);
			foreach (var num in numbers) 
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine();

			strings = SortArray(strings);
			foreach (var str in strings) 
			{
				Console.Write("{0} ", str);
			}
			Console.WriteLine();

			dates = SortArray(dates);
			foreach (var date in dates) 
			{
				Console.Write("{0} ", date);
			}
			Console.WriteLine();
		}

		static T[] SortArray<T>(T[] arr) where T : System.IComparable<T>
		{
			for (int i = 0; i < arr.Length - 1; i++)
			{
				int min = i;
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j].CompareTo(arr[min]) < 0)
					{
						min = j;
					}
				}
				if (min != i)
				{
					T temp = arr[i];
					arr[i] = arr[min];
					arr[min] = temp; 
				}
			}
			return arr;
		}
	}
}
