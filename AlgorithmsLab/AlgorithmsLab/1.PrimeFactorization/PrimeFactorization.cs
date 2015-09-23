using System;
using System.Collections.Generic;

namespace PrimeFactorization
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			Console.Write ("{0} = ", n);

			Queue<int> primeMultiples = new Queue<int> ();
			int divisor = 2;
			while (n > 1) {
				if (n % divisor == 0) {
					primeMultiples.Enqueue(divisor);
					n /= divisor;
				} else {
					divisor++;
				}
			}
			Console.WriteLine (String.Join (" * ", primeMultiples));
		}
	}
}
