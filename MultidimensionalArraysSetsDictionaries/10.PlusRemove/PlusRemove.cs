using System;
using System.Collections.Generic;

namespace PlusRemove
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Queue<string> input = new Queue<string>();
			do 
			{
				input.Enqueue(Console.ReadLine());
			} while (input.Contains("END") == false);
			char[][] text = new char[input.Count - 1][];
			int i = 0;
			while (input.Count > 1)
			{
				text[i] = input.Dequeue().ToCharArray();
				i++;
			}		
		}
	}
}
