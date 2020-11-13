using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Forces : Form
    {
        Vector Gravity = new Vector();
        Vector Buyoancy = new Vector();
        Ball ball;

        public Forces()
        {
            InitializeComponent();
            Vector R, V;
            ball = new Ball(R = new Vector(0, 10), V = new Vector(0, 10), 10.0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double dt = timer.Interval / 1000.0;
            ball.Move(dt, Gravity + Buyoancy);
        }

        private void tbGravity_Scroll(object sender, EventArgs e)
        {
            Gravity = new Vector(0, Convert.ToDouble(tbGravity.Value));
        }

        private void tbBuyoancy_Scroll(object sender, EventArgs e)
        {
            Buyoancy = new Vector(0, Convert.ToDouble(tbBuyoancy.Value));
        }

        private void button_Click(object sender, EventArgs e)
        {
            pbBall.Location = new Point(Convert.ToInt32(ball.R), Convert.ToInt32(ball.R));
        }
    }
}