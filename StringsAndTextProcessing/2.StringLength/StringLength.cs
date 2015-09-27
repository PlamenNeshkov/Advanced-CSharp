using System;

namespace StringLength
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine();
			char[] result = new char[20];
			for (int i = 0; i < 20; i++)
			{
				if (i < input.Length)
				{
					result[i] = input[i];
				}
				else
				{
					result[i] = '*';
				}
			}
			Console.WriteLine(new string(result));
		}
	}
}
