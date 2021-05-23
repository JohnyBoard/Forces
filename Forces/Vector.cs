public class Vector
{
        public Vector() : this(0, 0) { }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector Projection(Vector onVector) => this * onVector / onVector.SquareAbs * onVector;

        public static Vector operator +(Vector a, Vector b) => new Vector(a.X + b.X, a.Y + b.Y);

        public static Vector operator -(Vector v) => new Vector(-v.X, -v.Y);

        public static Vector operator -(Vector a, Vector b) => a + -b;

        public static Vector operator *(Vector v, int n) => new Vector(v.X * n, v.Y * n);

        public static Vector operator *(int n, Vector v) => v * n;

        public static int operator *(Vector a, Vector b) => a.X * b.X + a.Y * b.Y;

        public int X { get; set; }

        public int Y { get; set; }

        public int SquareAbs => this * this;

        public int Abs => (int)Math.Round(Math.Sqrt(SquareAbs));        
}