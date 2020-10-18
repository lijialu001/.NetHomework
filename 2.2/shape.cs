using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
	public interface IShape
	{
		bool IsValid();
		double Area { get; }
	}

	public class Rectangle : IShape
	{
		public virtual double Length { get; set; }
		public virtual double Width { get; set; }


		public Rectangle(double length = 1, double width = 1)
		{
			Length = length;
			Width = width;
		}

		public bool IsValid() => Length > 0 && Width > 0;
		public double Area
		{
			get
			{
				if (!IsValid()) { throw new InvalidOperationException(); }
				return Length * Width;
			}
		}
	}

	public class Square : Rectangle
	{
		private double side;

		public Square(double sideLength = 1)
		{
			side = sideLength;
		}

		public override double Length
		{
			get => side;
			set => side = value;
		}

		public override double Width
		{
			get => side;
			set => side = value;
		}
	}

	public class Triangle : IShape
	{
		public double Side1 { get; set; }
		public double Side2 { get; set; }
		public double Side3 { get; set; }

		public Triangle(double sideLength1 = 1, double sideLength2 = 1, double sideLength3 = 1)
		{
			Side1 = sideLength1;
			Side2 = sideLength2;
			Side3 = sideLength3;
		}

		public bool IsValid()
		{
			return Side1 > 0 && Side2 > 0 && Side3 > 0 &&
				Side1 + Side2 > Side3 &&
				Side1 + Side3 > Side2 &&
				Side2 + Side3 > Side1;
		}

		public double Area
		{
			get
			{
				if (!IsValid()) { throw new InvalidOperationException(); }
				double p = (Side1 + Side2 + Side3) / 2;
				return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
			}
		}
	}
}