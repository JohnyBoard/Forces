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
        Vector G = new Vector(0, 980);
        Ball ball;  
        double density = 0, M;
        Vector R, V;

        public Forces()
        {
            InitializeComponent();
            ball = new Ball(R, V = new Vector(0, 10), M);
            string[] Areas = { "Milk", "Mercury", "Water", "Kerosene", "Petrol", "Oil", "Acetone" };
            lbArea.Items.AddRange(Areas);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double dt = timer.Interval / 1000.0;
            Gravity = M * G;
            Buyoancy = (density * G) * V;
            ball.Move(dt, Gravity + Buyoancy);
            pbBall.Location = new Point(Convert.ToInt32(ball.R.X), Convert.ToInt32(ball.R.Y));
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (density == 0)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                timer.Start();
            }
        }

        private void tbMass_Scroll(object sender, EventArgs e)
        {
            M = tbMass.Value;
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            R = new Vector(0, tbVolume.Value);
        }

        private void lbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lbArea.SelectedItem)
            {
                case "Milk":
                    density = 1040;
                    break;
                case "Mercury":
                    density = 13600;
                    break;
                case "Water":
                    density = 1000;
                    break;
                case "Kerosene":
                    density = 820;
                    break;
                case "Petrol":
                    density = 710;
                    break;
                case "Oil":
                    density = 800;
                    break;
                case "Acetone":
                    density = 792;
                    break;
            }
        }
    }
}