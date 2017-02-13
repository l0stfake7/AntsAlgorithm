﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsAlgorithm.Classes
{
    class Utilities
    {
        public static bool InsideCircle(int xc, int yc, int r, int x, int y)
        {
            int dx = xc - x;
            int dy = yc - y;
            return dx * dx + dy * dy <= r * r;
        }

        public static double DistanceInStraightLineBetweenPoints(Point point1, Point point2)
        {
            var a = (double)(point2.X - point1.X);
            var b = (double)(point2.Y - point1.Y);

            return Math.Sqrt(a * a + b * b);
        }
    }
}
