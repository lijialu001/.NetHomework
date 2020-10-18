using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1
{
    public class Rectangle : Shape
    {
        public Rectangle(Point a, Point b)
        {
            if (Math.Abs(a.x - b.x) < 1e-9 || Math.Abs(a.y - b.y) < 1e-9) throw new InvalidShape();

            Points.Add(new Point(a));
            Points.Add(new Point(b));
        }

        public override double Aera()
        {
            return Math.Abs(Points[0].x - Points[1].x)*Math.Abs(Points[0].y-Points[1].y);
        }
    }
}
