using System;

namespace _2._3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new GenericList<int>();

            list.Add(1);
            list.Add(9);
            list.Add(1);
            list.Add(9);
            list.Add(8);
            list.Add(1);
            list.Add(0);

            var max = int.MinValue;
            var min = int.MaxValue;
            var sum = 0;

            list.ForEach(s =>
            {
                max = Math.Max(max, s);
                min = Math.Min(min, s);
                sum += s;
            }
            );

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
        }
    }
}