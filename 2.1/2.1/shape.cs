using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1
{
    public abstract class Shape
        {
            protected List<Point> Points = new List<Point>();

            public abstract double Aera();
        }
}
