using System;
using System.Text;

namespace UnicodeCharacters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text = Console.ReadLine();
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < text.Length; i++)
			{
				result.Append(String.Format(@"\u{0:x4}", (ushort)text[i]));
			}
			Console.WriteLine(result);
		}
	}
}
