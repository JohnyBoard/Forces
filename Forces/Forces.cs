using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forces
{
    public partial class Forces : Form
    {
        public Vector Gravity = new Vector(), Buyoancy = new Vector(), R, V, G = new Vector(0, 981);
        public double areaDensity = 1, itemDensity = 1;  
        Item item;

        private void cbPlanets_SelectedIndexChanged(object sender, EventArgs e) => G = new Vector(0, Falling((string)cbPlanets.SelectedItem));

        public int Falling(string s)
        {
            switch(s)
            {
                case "Земля": return 981;
                case "Луна": return 162;
                case "Венера": return 88;
                case "Юпитер": return 2480;
                case "Уран": return 886;
                case "Эрида": return 84;
                case "Солнце": return 27310;
                case "Меркурий": return 370;
                case "Марс": return 386;
                case "Сатурн": return 1044;
                case "Нептун": return 1109;
                case "Плутон": return 61;
                case "Европа": return 131;
                case "Ганимед": return 142;
                case "Титан": return 135;
                case "Тритон": return 77;
                default: return 180;
            }
        }

        private void cbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAreas.SelectedItem)
            {
                case "Молоко":
                    areaDensity = 1040;
                    pnlField.BackColor = Color.White;
                    break;
                case "Ртуть":
                    areaDensity = 1360;
                    pnlField.BackColor = Color.Gray;
                    break;
                case "Вода":
                    areaDensity = 1000;
                    pnlField.BackColor = Color.Aqua;
                    break;
                case "Керосин":
                    areaDensity = 8200;
                    pnlField.BackColor = Color.GreenYellow;
                    break;
                case "Бензин":
                    areaDensity = 7100;
                    pnlField.BackColor = Color.Purple;
                    break;
                case "Нефть":
                    areaDensity = 8000;
                    pnlField.BackColor = Color.Black;
                    break;
                case "Ацетон":
                    areaDensity = 7920;
                    pnlField.BackColor = Color.Brown;
                    break;
                case "Мёд":
                    areaDensity = 1350;
                    pnlField.BackColor = Color.Orange;
                    break;
                case "Воздух":
                    areaDensity = 1290;
                    pnlField.BackColor = Color.Gray;
                    break;
                case "Кислород":
                    areaDensity = 1430;
                    pnlField.BackColor = Color.LightGray;
                    break;
            }
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbItems.SelectedItem)
            {
                case "Золото":
                    itemDensity = 1930;
                    pbItem.Image = Image.FromFile(@"Images\Gold.png");
                    break;
                case "Свинец":
                    itemDensity = 1130;
                    pbItem.Image = Image.FromFile(@"Images\Lead.png");
                    break;
                case "Серебро":
                    itemDensity = 1050;
                    pbItem.Image = Image.FromFile(@"Images\Silver.png");
                    break;
                case "Фарфор":
                    itemDensity = 2300;
                    pbItem.Image = Image.FromFile(@"Images\Porcelain.png");
                    break;
                case "Лёд":
                    itemDensity = 9000;
                    pbItem.Image = Image.FromFile(@"Images\Ice.png");
                    break;
                case "Кирпич":
                    itemDensity = 1800;
                    pbItem.Image = Image.FromFile(@"Images\Brick.png");
                    break;
                case "Платина":
                    itemDensity = 23500;
                    pbItem.Image = Image.FromFile(@"Images\Platinum.png");
                    break;               
            }
        }

        public Forces()
        {
            InitializeComponent();
            item = new Item (R = new Vector(0, 0), V = new Vector(0, 10), 1, 1);
            string[] Areas = { "Молоко", "Ртуть", "Вода", "Керосин", "Бензин", "Нефть", "Ацетон", "Мёд", "Воздух", "Кислород" };
            cbAreas.Items.AddRange(Areas);
            string[] Items = { "Золото", "Свинец", "Серебро", "Фарфор", "Лёд", "Кирпич", "Платина" };
            cbItems.Items.AddRange(Items);
            string[] Planets = { "Земля", "Луна", "Венера", "Юпитер", "Уран", "Эрида", "Солнце", "Меркурий", "Марс", "Сатурн", "Нептун", "Плутон", "Фобос", "Ио", "Европа", "Каллисто", "Титан", "Ганнимед", "Тритон" };
            cbPlanets.Items.AddRange(Planets);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double dt = timer.Interval / 1000.0;
            item.Move(dt, Gravity + Buyoancy);
            pbItem.Location = new Point(Convert.ToInt32(item.R.X), Convert.ToInt32(item.R.Y));
        }

        private void button_Click(object sender, EventArgs e)
        {
            item.Mass = item.Volume * itemDensity;
            Gravity = item.Mass * G;
            Buyoancy = -(areaDensity * G) * item.Volume;
            timer.Start();
            lblVolume.Text = "Объем тела: " + item.Volume;
            lblItemDensity.Text = "Плотность тела: " + itemDensity;
            lblAreaDensity.Text = "Плотность среды: " + areaDensity;
            lblItemMass.Text = "Масса тела: " + item.Mass;
            lblArchimed.Text = "Сила тяжести: " + Gravity;
            lblArchimed.Text = "Сила Архимеда: " + Buyoancy;
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            item.Volume = tbVolume.Value == 0 ? 1 : tbVolume.Value;
            pbItem.Size = new Size((int)item.Volume, (int)item.Volume);
        }
    }
}