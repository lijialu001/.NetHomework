﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1
{
    public class Square : Rectangle
    {
        public Square(Point p1, Point p2) : base(p1, p2)
        {
            var l1 = Math.Abs(p1.x - p2.x);
            var l2 = Math.Abs(p1.y - p2.y);

            if (Math.Abs(l1 - l2) > 1e-9) throw new InvalidShape();
        }
    }
}
