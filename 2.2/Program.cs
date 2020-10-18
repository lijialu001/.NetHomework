using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
	class Program
	{
		static void Main(string[] args)
		{
			ShapeFactory factory = new ShapeFactory();
			List<IShape> shapes = new List<IShape>();
			for (int i = 0; i < 10; i++)
				shapes.Add(factory.GetRandomShape());
			double totalArea = 0;
			foreach (IShape i in shapes)
			{
				Console.WriteLine($"Shape {i.GetType().ToString()} generated with area {i.Area:F6}");
				totalArea += i.Area;
			}
			Console.WriteLine($"\nTotal area: {totalArea:F6}");

			object o = 1;
		}
	}
}
