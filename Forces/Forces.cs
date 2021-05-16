using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forces
{
    public partial class Forces : Form
    {
        public Vector Gravity = new Vector(), Buyoancy = new Vector(), R, V, G = new Vector(1, 980);
        public double areaDensity = 1, objectDensity = 1, M = 1;
        Ball ball;          

        public Forces()
        {
            InitializeComponent();
            ball = new Ball(R = new Vector(0, 0), V = new Vector(0, 10), M);
            string[] Areas = { "Молоко", "Ртуть", "Вода", "Керосин", "Бензин", "Нефть", "Ацетон", "Мёд", "Воздух", "Кислород" };
            lbArea.Items.AddRange(Areas);
            string[] Objects = { "Золото", "Свинец", "Серебро", "Фарфор", "Лёд", "Кирпич", "Платина", "Малыш Йода" };
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
                case "Золото":
                    objectDensity = 1930000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Gold.png");
                    break;
                case "Свинец":
                    objectDensity = 1130000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Lead.png");
                    break;
                case "Серебро":
                    objectDensity = 1050000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Silver.png");
                    break;
                case "Фарфор":
                    objectDensity = 230000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Porcelain.png");
                    break;
                case "Лёд":
                    objectDensity = 90000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Ice.png");
                    break;
                case "Кирпич":
                    objectDensity = 180000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Brick.png");
                    break;
                case "Платина":
                    objectDensity = 2350000;
                    pbBall.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Platinum.png");
                    break;
                case "Малыш Йода":
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
                case "Молоко":
                    areaDensity = 104000;
                    pnlField.BackColor = Color.White;
                    break;
                case "Ртуть":
                    areaDensity = 1360000;
                    pnlField.BackColor = Color.Gray;
                    break;
                case "Вода":
                    areaDensity = 100000;
                    pnlField.BackColor = Color.Aqua;
                    break;
                case "Керосин":
                    areaDensity = 82000;
                    pnlField.BackColor = Color.GreenYellow;
                    break;
                case "Бензин":
                    areaDensity = 71000;
                    pnlField.BackColor = Color.Purple;
                    break;
                case "Нефть":
                    areaDensity = 80000;
                    pnlField.BackColor = Color.Black;
                    break;
                case "Ацетон":
                    areaDensity = 79200;
                    pnlField.BackColor = Color.Brown;
                    break;
                case "Мёд":
                    areaDensity = 135000;
                    pnlField.BackColor = Color.Orange;
                    break;
                case "Воздух" :
                    areaDensity = 1290;
                    pnlField.BackColor = Color.Gray;
                    break;
                case "Кислород":
                    areaDensity = 1430;
                    pnlField.BackColor = Color.LightGray;
                    break;
            }            
        }
    }
}