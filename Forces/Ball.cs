using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forces
{
    public class Ball
    {
        public Ball(Vector r, Vector v, double m)
        {
            R = r;
            V = v;
            M = m;
        }
        
        public Vector R { get; set; }

        public Vector V { get; set; }

        public double M { get; set; }

        public void Move(double dt, Vector F)
        {
            Vector a = F / M;
            V += a * dt;
            Move(dt);
        }

        public void Move(double dt)
        {
            R += V * dt;
        }
    }
}
