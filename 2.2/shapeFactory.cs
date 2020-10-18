using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2
{
	class ShapeFactory
	{
		private Random rd = new Random();

		public IShape GetRandomShape()
		{
			IShape shape = null;
			switch (rd.Next(0, 3))
			{
				case 0: shape = GetShape(typeof(Rectangle), rd.NextDouble(), rd.NextDouble()); break;
				case 1: shape = GetShape(typeof(Square), rd.NextDouble()); break;
				case 2:
					do shape = GetShape(typeof(Triangle), rd.NextDouble(), rd.NextDouble(), rd.NextDouble());
					while (!shape.IsValid());
					break;
			}
			return shape;
		}

		public IShape GetShape(Type type, params double[] vs)
		{
			if (type == typeof(Rectangle))
			{
				if (vs.Length < 2) throw new ArgumentException("Too few arguments.");
				return new Rectangle(vs[0], vs[1]);
			}
			else if (type == typeof(Square))
			{
				if (vs.Length < 1) throw new ArgumentException("Too few arguments.");
				return new Square(vs[0]);
			}
			else if (type == typeof(Triangle))
			{
				if (vs.Length < 3) throw new ArgumentException("Too few arguments.");
				return new Triangle(vs[0], vs[1], vs[2]);
			}
			else throw new ArgumentException("Invalid type.");
		}
	}
}