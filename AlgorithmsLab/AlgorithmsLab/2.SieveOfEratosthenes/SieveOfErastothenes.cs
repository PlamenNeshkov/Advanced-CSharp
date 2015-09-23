using System;

namespace SieveOfEratosthenes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] nums = new int[n+1];
			for (int i = 0; i <= n; i++) 
			{
				nums[i] = i;
			}

			int p = 2;
			for (int i = p*2; i <= n; i += p)
			{
					nums[i] = -1;
			}
			Console.Write(p);
			bool allMarked;
			do 
			{
				allMarked = false;
				p++;
				while (p < nums.Length && nums[p] == -1) 
				{
					p++;
				}
				if (p == nums.Length)
				{
					allMarked = true;
				}
				else
				{
					Console.Write(", {0}", p);
					for (int i = p*2; i <= n; i += p)
					{
						nums[i] = -1;
					}
				} 
			} while (!allMarked);
		}
	}
}
