using System;
using System.Linq;
using System.Collections.Generic;

namespace LargestRectangle
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Queue<string> lines = new Queue<string>();
			do 
			{
				lines.Enqueue(Console.ReadLine());
			} while (!lines.Contains("END"));

			char[][] matrix = new char[lines.Count - 1][];
			int i = 0;
			while (lines.Count > 1)
			{
				matrix[i] = lines.Dequeue().Split(',')
				            .SelectMany(x => x.ToCharArray()).ToArray();
				i++;
			}
		}
	}
}
