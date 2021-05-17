using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forces
{
    public partial class Forces : Form
    {
        public Vector Gravity = new Vector(), Buyoancy = new Vector(), R, V, G = new Vector(0, 981);
        public double areaDensity = 1, objectDensity = 1, mass = 1, volume = 1;        
        Item item;

        private void cbPlanets_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPlanets.SelectedItem)
            {
                case "Земля":
                    G = new Vector(0, 981);
                    break;
                case "Луна":
                    G = new Vector(0, 162);
                    break;
                case "Венера":
                    G = new Vector(0, 888);
                    break;
                case "Юпитер":
                    G = new Vector(0, 2480);
                    break;
                case "Уран":
                    G = new Vector(0, 886);
                    break;
                case "Эрида":
                    G = new Vector(0, 84);
                    break;
                case "Солнце":
                    G = new Vector(0, 27310);
                    break;
                case "Меркурий":
                    G = new Vector(0, 370);
                    break;
                case "Марс":
                    G = new Vector(0, 386);
                    break;
                case "Сатурн":
                    G = new Vector(0, 1044);
                    break;
                case "Нептун":
                    G = new Vector(0, 1109);
                    break;
                case "Плутон":
                    G = new Vector(0, 61);
                    break;
                case "Европа":
                    G = new Vector(0, 131);
                    break;
                case "Ганимед":
                    G = new Vector(0, 142);
                    break;
                case "Титан":
                    G = new Vector(0, 135);
                    break;
                case "Тритон":
                    G = new Vector(0, 77);
                    break;
                case "Ио":
                    G = new Vector(0, 180);
                    break;
                case "Каллисто":
                    G = new Vector(0, 179);
                    break;
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
                    objectDensity = 1930;
                    pbItem.Image = Image.FromFile(@"Images\Gold.png");
                    break;
                case "Свинец":
                    objectDensity = 1130;
                    pbItem.Image = Image.FromFile(@"Images\Lead.png");
                    break;
                case "Серебро":
                    objectDensity = 1050;
                    pbItem.Image = Image.FromFile(@"Images\Silver.png");
                    break;
                case "Фарфор":
                    objectDensity = 2300;
                    pbItem.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Porcelain.png");
                    break;
                case "Лёд":
                    objectDensity = 9000;
                    pbItem.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Ice.png");
                    break;
                case "Кирпич":
                    objectDensity = 1800;
                    pbItem.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Brick.png");
                    break;
                case "Платина":
                    objectDensity = 23500;
                    pbItem.Image = Image.FromFile("E:\\D\\ВАНЯ ЕГО Док\\Программирование\\C# Advanced\\Forms\\Forces\\Forces\\bin\\Debug\\Images\\Platinum.png");
                    break;               
            }
        }

        public Forces()
        {
            InitializeComponent();
            item = new Item (R = new Vector(0, 0), V = new Vector(0, 10), mass, volume);
            string[] Areas = { "Молоко", "Ртуть", "Вода", "Керосин", "Бензин", "Нефть", "Ацетон", "Мёд", "Воздух", "Кислород" };
            cbAreas.Items.AddRange(Areas);
            string[] Items = { "Золото", "Свинец", "Серебро", "Фарфор", "Лёд", "Кирпич", "Платина", "Малыш Йода" };
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
            item.Mass = item.Volume * objectDensity;
            Gravity = item.Mass * G;
            Buyoancy = -(areaDensity * G) * item.Volume;
            timer.Start();
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            //изменение размера
            item.Volume = tbVolume.Value;
        }
    }
}