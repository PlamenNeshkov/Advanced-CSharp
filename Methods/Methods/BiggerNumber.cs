﻿using System;

namespace Methods
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());

			int max = GetMax(firstNumber, secondNumber);
			Console.WriteLine(max);
		}

		static int GetMax(int firstNumber, int secondNumber)
		{
			if (firstNumber > secondNumber)
			{
				return firstNumber;
			}
			else 
			{
				return secondNumber;
			}
		}
	}
}
