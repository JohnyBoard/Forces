﻿namespace Forces
{
    public class Vector
    {
        public Vector() : this(0, 0) { }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector a, Vector b) => new Vector(a.X + b.X, a.Y + b.Y);

        public static Vector operator -(Vector v) => new Vector(-v.X, -v.Y);
        
        public static Vector operator *(Vector v, double n) => new Vector(v.X * n, v.Y * n);

        public static Vector operator /(Vector v, double n) => v * (1 / n);

        public static Vector operator *(double n, Vector v) => v * n;

        public double X { get; set; }

        public double Y { get; set; }
    }
}