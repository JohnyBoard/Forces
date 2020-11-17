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
        Vector G = new Vector(1, 980);
        Ball ball;  
        public double areaDensity = 1, objectDensity = 1, M = 1;
        Vector R, V;

        public Forces()
        {
            InitializeComponent();
            ball = new Ball(R = new Vector(0, 0), V = new Vector(0, 10), M);
            string[] Areas = { "Milk", "Mercury", "Water", "Kerosene", "Petrol", "Oil", "Acetone", "Honey", "Air", "Oxygen" };
            lbArea.Items.AddRange(Areas);
            string[] Objects = { "Gold", "Lead", "Silver", "Porcelain", "Ice", "Brick", "Platinum", "Baby Yoda" };
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
                    objectDensity = 1930000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Gold.png");
                    break;
                case "Lead":
                    objectDensity = 1130000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Lead.png");
                    break;
                case "Silver":
                    objectDensity = 1050000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Silver.png");
                    break;
                case "Porcelain":
                    objectDensity = 230000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Porcelain.png");
                    break;
                case "Ice":
                    objectDensity = 90000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Ice.png");
                    break;
                case "Brick":
                    objectDensity = 180000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Brick.png");
                    break;
                case "Platinum":
                    objectDensity = 2350000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Platinum.png");
                    break;
                case "Baby Yoda":
                    objectDensity = 100000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Baby Yoda.png");
                    break;
            }
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            ball.Volume = tbVolume.Value;
            pbBall.Size = new Size(pbBall.Width += Convert.ToInt32(ball.Volume) / 100, pbBall.Height += Convert.ToInt32(ball.Volume) / 100);
        }

        private void lbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lbArea.SelectedItem)
            {
                case "Milk":
                    areaDensity = 104000;
                    pnlField.BackColor = Color.White;
                    break;
                case "Mercury":
                    areaDensity = 1360000;
                    pnlField.BackColor = Color.Gray;
                    break;
                case "Water":
                    areaDensity = 100000;
                    pnlField.BackColor = Color.Aqua;
                    break;
                case "Kerosene":
                    areaDensity = 82000;
                    pnlField.BackColor = Color.GreenYellow;
                    break;
                case "Petrol":
                    areaDensity = 71000;
                    pnlField.BackColor = Color.Purple;
                    break;
                case "Oil":
                    areaDensity = 80000;
                    pnlField.BackColor = Color.Black;
                    break;
                case "Acetone":
                    areaDensity = 79200;
                    pnlField.BackColor = Color.Brown;
                    break;
                case "Honey":
                    areaDensity = 135000;
                    pnlField.BackColor = Color.Orange;
                    break;
                case "Air":
                    areaDensity = 1290;
                    pnlField.BackColor = Color.Gray;
                    break;
                case "Oxygen":
                    areaDensity = 1430;
                    pnlField.BackColor = Color.LightGray;
                    break;
            }            
        }
    }
}