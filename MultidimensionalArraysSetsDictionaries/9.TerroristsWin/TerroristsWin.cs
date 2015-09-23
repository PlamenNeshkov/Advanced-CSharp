using System;
using System.Collections.Generic;

namespace TerroristsWin
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] input = Console.ReadLine().ToCharArray();
			char[] result = new char[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] != '|') 
				{
					result[i] = input[i];
				}
				else
				{
					List<char> bomb = new List<char>();
					i++;
					while (input[i] != '|')
					{
						bomb.Add(input[i]);
						i++;
					}
					int sum = 0;
					foreach (var ch in bomb)
					{
						sum += ch;
					}
					int rem = sum % 10;
					for (int k = i; k >= i - rem - bomb.Count - 1; k--) 
					{
						if (k >= 0) 
						{
							result[k] = '.';
						}
					}
					for (int k = i + 1; k <= i + rem; k++)
					{
						if (k < result.Length) 
						{
							result[k] = '.';
						}
					}
					i += rem;
				}
			}
			foreach (var ch in result) 
			{
				Console.Write(ch);
			}
			Console.WriteLine();
		}
	}
}
