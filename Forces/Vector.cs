using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forces
{
    public class Vector
    {
        public Vector() : this(0, 0) { }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return a + -b;
        }

        public static Vector operator *(Vector v, double n)
        {
            return new Vector(v.X * n, v.Y * n);
        }

        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.X * b.X, a.Y * b.Y);
        }

        public static Vector operator /(Vector v, double n)
        {
            return v * (1 / n);
        }

        public static Vector operator *(double n, Vector v)
        {
            return v * n;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }
}