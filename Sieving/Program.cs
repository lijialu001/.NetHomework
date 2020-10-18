using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sieving
{
	class Program
	{
		static List<int> GetPrimes(int n)
		{
			bool[] notPrime = new bool[n + 1];
			List<int> primes = new List<int>();
			for (int i = 2; i <= n; i++)
			{
				if (!notPrime[i])
				{
					primes.Add(i);
					for (int j = i * 2; j <= n; j += i)
					{
						notPrime[j] = true;
					}
				}
			}
			return primes;
		}
		static void Main(string[] args)
		{
			List<int> primes = GetPrimes(100);
			foreach (int i in primes)
			{
				Console.WriteLine(i);
			}
		}
	}

}
