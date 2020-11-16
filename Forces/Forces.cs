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
        public Vector Gravity = new Vector();
        public Vector Buyoancy = new Vector();
        Vector G = new Vector(980, 980);
        Ball ball;  
        public double areaDensity = 1, objectDensity = 1, M = 1;
        Vector R, V;

        public Forces()
        {
            InitializeComponent();
            ball = new Ball(R = new Vector(0, 0), V = new Vector(0, 10), M);
            string[] Areas = { "Milk", "Mercury", "Water", "Kerosene", "Petrol", "Oil", "Acetone", "Honey" };
            lbArea.Items.AddRange(Areas);
            string[] Objects = { "Gold", "Lead", "Silver", "Porcelain", "Ice" };
            lbObject.Items.AddRange(Objects);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double dt = timer.Interval / 1000.0;
            ball.Move(dt, Gravity + Buyoancy);
            pbBall.Location = new Point(Convert.ToInt32(ball.R.X), Convert.ToInt32(ball.R.Y));
        }

        private void button_Click(object sender, EventArgs e)
        {
            ball.M = ball.Volume * objectDensity;
            Gravity = ball.M * G;
            Buyoancy = -(areaDensity * G) * ball.Volume;
            timer.Start();
        }

        private void lbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbObject.SelectedItem)
            {
                case "Gold":
                    objectDensity = 19300;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Gold.png");
                    break;
                case "Lead":
                    objectDensity = 11300;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Lead.png");
                    break;
                case "Silver":
                    objectDensity = 10500;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Silver.png");
                    break;
                case "Porcelain":
                    objectDensity = 2300;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Porcelain.png");
                    break;
                case "Ice":
                    objectDensity = 900;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Ice.png");
                    break;
            }
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            ball.Volume = tbVolume.Value;
        }

        private void lbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lbArea.SelectedItem)
            {
                case "Milk":
                    areaDensity = 1040;
                    pnlField.BackColor = Color.White;
                    break;
                case "Mercury":
                    areaDensity = 13600;
                    pnlField.BackColor = Color.Gray;
                    break;
                case "Water":
                    areaDensity = 1000;
                    pnlField.BackColor = Color.Aqua;
                    break;
                case "Kerosene":
                    areaDensity = 820;
                    pnlField.BackColor = Color.GreenYellow;
                    break;
                case "Petrol":
                    areaDensity = 710;
                    pnlField.BackColor = Color.Purple;
                    break;
                case "Oil":
                    areaDensity = 800;
                    pnlField.BackColor = Color.Black;
                    break;
                case "Acetone":
                    areaDensity = 792;
                    pnlField.BackColor = Color.Brown;
                    break;
                case "Honey":
                    areaDensity = 1350;
                    pnlField.BackColor = Color.Orange;
                    break;
            }            
        }
    }
}