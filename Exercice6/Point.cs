using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    struct Point
    {
        internal int X;
        internal int Y;
        
        public static implicit operator Point3D(Point point)
        {
            return new Point3D() {X = point.X, Y = point.Y, Z = 0};
        }

        public override string ToString() => $"X:{X}, Y:{Y}";

        public static Point operator +(Point pointFirst, Point pointSecond)
        {
            return new Point() {X = pointFirst.X + pointSecond.X, Y = pointFirst.Y + pointSecond.Y};
        }

        public static Point operator +(Point pointFirst, Point3D pointSecond)
        {
            return new Point() {X = pointFirst.X+pointSecond.X, Y = pointFirst.Y+pointSecond.Y};
        }
    }
}
