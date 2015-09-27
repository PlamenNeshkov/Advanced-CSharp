using System;
using System.Text;

namespace TextFilter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] bannedWords = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			string text = Console.ReadLine();
			for (int i = 0; i < bannedWords.Length; i++)
			{
				StringBuilder temp = new StringBuilder(text);
				temp.Replace(bannedWords[i], new String('*', bannedWords[i].Length));
				text = temp.ToString();
			}	
			Console.WriteLine(text);
		}
	}
}
