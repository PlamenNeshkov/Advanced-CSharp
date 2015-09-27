using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Palindromes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			SortedSet<string> palindromes = new SortedSet<string>();
			string[] input = Console.ReadLine().Split(new char[] {' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < input.Length; i++)
			{
				if (Palindrome(input[i]))
				{
					palindromes.Add(input[i]);
				}
			}

			Console.WriteLine(String.Join(", ", palindromes));
		}

		private static bool Palindrome(string text)
		{
			for (int i = 0; i < (text.Length/2); i++)
			{
				if (text[i] != text[text.Length - i - 1])
				{
					return false;
				}
			}
			return true;
		}
	}
}
