using System;
using System.Text;

namespace CountSubstringOccurences
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text = Console.ReadLine();
			string term = Console.ReadLine();
			int count = 0;
			while (text.IndexOf(term) != -1)
			{
				StringBuilder temp = new StringBuilder(text);
				temp.Remove(text.IndexOf(term), 1);
				text = temp.ToString();
				count++;
			}
			Console.WriteLine(count);
		}
	}
}
