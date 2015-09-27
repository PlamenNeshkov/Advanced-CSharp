using System;
using System.Linq;

namespace ReverseString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string str = Console.ReadLine();
			char[] text = str.ToCharArray();
			Array.Reverse(text);
			str = new string(text);
			Console.WriteLine(str);
		}
	}
}
