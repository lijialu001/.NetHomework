using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCalculate
{
	public struct ArrayStats
	{
		public int min, max, sum;
		public double avg;
	}
	class Program
	{
		static ArrayStats GetStats(int[] array)
		{
			ArrayStats stats = new ArrayStats() { min = 2147483647, max = -2147483648, sum = 0 };
			foreach (int i in array)
			{
				stats.min = Math.Min(stats.min, i);
				stats.max = Math.Max(stats.max, i);
				stats.sum += i;
			}
			stats.avg = ((double)stats.sum) / array.Count();
			return stats;
		}

		static int[] ReadArray()
		{
			List<int> list = new List<int>();
			string str = Console.ReadLine().Trim(' ');
			foreach (string s in str.Split(' '))
			{
				list.Add(int.Parse(s));
			}
			int[] array = new int[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array[i] = list[i];
			}
			return array;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the array in one line:");
			int[] array;
			try { array = ReadArray(); }
			catch (Exception) { Console.WriteLine("Invalid input!"); return; }
			ArrayStats stats = GetStats(array);
			Console.WriteLine($"Max: {stats.max}\nMin: {stats.min}\nAvg: {stats.avg:F6}\nSum: {stats.sum}");
		}
	}

}
