using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Forces
{
    public partial class Forces : Form
    {
        public Vector Gravity = new Vector(), Buyoancy = new Vector(), R, V, G = new Vector(0, 981);
        public double areaDensity = 1, itemDensity = 1;
        Item item;
        double addedVolume = 0;
        double addedMass = 0;
        Vector AddedBuyoancy = new Vector();
        Vector AddedGravity = new Vector();
        private Dictionary<string, int> PlanetG = new Dictionary<string, int>
        {
            ["Земля"] = 981,
            ["Луна"] = 162,
            ["Венера"] = 88,
            ["Юпитер"] = 2480,
            ["Уран"] = 886,
            ["Эрида"] = 84,
            ["Солнце"] = 27310,
            ["Меркурий"] = 370,
            ["Марс"] = 386,
            ["Сатурн"] = 1044,
            ["Нептун"] = 1109,
            ["Плутон"] = 61,
            ["Европа"] = 131,
            ["Ганимед"] = 142,
            ["Титан"] = 135,
            ["Тритон"] = 77
        };

        private Entity[] entities =
         {
                new Entity( "Золото",
                     1930,@"Images\Gold.png"),
                new Entity( "Свинец",
                     1130,@"Images\Lead.png"),
                new Entity( "Серебро",
                     1050,@"Images\Silver.png")
                //    break;
                //new Entity( "Фарфор",
                //     2300;
                //    pbItem.Image = Image.FromFile(@"Images\Porcelain.png");
                //    break;
                //new Entity( "Лёд",
                //     9000;
                //    pbItem.Image = Image.FromFile(@"Images\Ice.png");
                //    break;
                //new Entity( "Кирпич",
                //     1800;
                //    pbItem.Image = Image.FromFile(@"Images\Brick.png");
                //    break;
                //new Entity( "Платина",
                //     23500;
                //    pbItem.Image = Image.FromFile(@"Images\Platinum.png");
                //    break;
        };

        private Area[] areas = { };
        //

        private void cbPlanets_SelectedIndexChanged(object sender, EventArgs e) => G = new Vector(0, PlanetG[(string)cbPlanets.SelectedItem]);


        private void cbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area area = areas.FirstOrDefault(a => a.Name == cbAreas.SelectedItem.ToString());
            itemDensity = area.Density;
            pnlField.BackColor = area.Color;
        }

        private void trAddedVolume_Scroll(object sender, EventArgs e)
        {
            addedVolume = trAddedVolume.Value;
            pbBalloon.Size = new Size((int)addedVolume, (int)addedVolume);
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Area area = areas.FirstOrDefault(a => a.Name == cbAreas.SelectedItem.ToString());
            //itemDensity = area.Density;
            //pnlField.BackColor = area.Color;
        }

        public Forces()
        {
            InitializeComponent();
            item = new Item(R = new Vector(0, 0), V = new Vector(0, 10), 1, 1);
            string[] Areas = areas.Select(x => x.Name).ToArray();
            cbAreas.Items.AddRange(Areas);
            string[] Items = { "Золото", "Свинец", "Серебро", "Фарфор", "Лёд", "Кирпич", "Платина" };
            cbItems.Items.AddRange(Items);
            string[] Planets = new string[PlanetG.Count];
            int i = 0;
            foreach (var keyval in PlanetG)
            {
                Planets[i] = keyval.Key;
                i++;
            }
            cbPlanets.Items.AddRange(Planets);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double dt = timer.Interval / 1000.0;
            item.Move(dt, Gravity + Buyoancy + AddedBuyoancy + AddedGravity);
            pbItem.Location = new Point(Convert.ToInt32(item.R.X), Convert.ToInt32(item.R.Y));
            pbBalloon.Top = pbItem.Top - pbBalloon.Height;
            pbWeight.Top = pbItem.Top + pbItem.Height;
        }

        private void button_Click(object sender, EventArgs e)
        {
            item.Mass = item.Volume * itemDensity;
            Gravity = item.Mass * G;
            Buyoancy = -(areaDensity * G) * item.Volume;
            AddedBuyoancy = -(areaDensity * G) * addedVolume;
            AddedGravity = addedMass * G;
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