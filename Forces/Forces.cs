using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Forces
{
    public partial class Forces : Form
    {
        public Vector Gravity, Buyoancy, R = new Vector(0, 0), V, AddedBuyoancy, AddedGravity, G = new Vector(0, 981);
        public double areaDensity = 1, itemDensity = 1, addedVolume = 0, addedMass = 0;
        Item item;
        Dictionary<string, double> PlanetG = new Dictionary<string, double>
        { //Н / кг
            ["Земля"] = 9.81,
            ["Луна"] = 1.62,
            ["Венера"] = 8.88,
            ["Юпитер"] = 24.79,
            ["Уран"] = 8.86,
            ["Эрида"] = 0.84,
            ["Солнце"] = 273.1,
            ["Меркурий"] = 3.7,
            ["Марс"] = 3.86,
            ["Сатурн"] = 10.44,
            ["Нептун"] = 11.09,
            ["Плутон"] = 0.617,
            ["Европа"] = 1.315,
            ["Ганимед"] = 1.428,
            ["Титан"] = 1.352,
            ["Тритон"] = 0.77
        };
        Entity[] entities = //кг на м^3
        {
            new Entity("Золото", 19300, @"Images\Gold.png"),
            new Entity("Свинец", 11300, @"Images\Lead.png"),
            new Entity("Серебро", 10500, @"Images\Silver.png"),
            new Entity("Фарфор", 2360, @"Images\Porcelain.png"),
            new Entity("Лёд", 900, @"Images\Ice.png"),
            new Entity("Кирпич", 1800, @"Images\Brick.png"),
            new Entity("Платина", 23500, @"Images\Platinum.png"),
            new Entity("Алмаз", 3500, @"Images\Diamond.png"),           
            new Entity("Гипс", 2300, @"Images\Gypsum.png"),            
            new Entity("Янтарь", 1100, @"Images\Amber.png"),
            new Entity("Уголь", 1450, @"Images\Coal.png"),
            new Entity("Масло", 865, @"Images\Butter.png"),
            new Entity("Латунь", 8500, @"Images\Brass.png"),
            new Entity("Кварц", 2650, @"Images\Quarz.png")
        };
        Area[] areas =  //кг на м^3
        {
            new Area("Мёд", 1450, Color.Yellow),
            new Area("Ртуть", 13600, Color.Gray),
            new Area("Вода", 1000, Color.Aqua),
            new Area("Молоко", 1030, Color.White),
            new Area("Бензин", 900, Color.Violet),
            new Area("Пиво", 1010, Color.Gold),
            new Area("Нефть", 800, Color.Black),
            new Area("Китовый жир", 925, Color.LightGoldenrodYellow),
            new Area("Льяное масло", 940, Color.Wheat),
            new Area("Подсолнечное масло", 920, Color.Olive),
            new Area("Дизельное топливо", 885, Color.Wheat)
        };

        public Forces()
        {
            InitializeComponent();
            item = new Item(new Vector(pbItem.Left, pbItem.Top), new Vector(0, 0), 1, 1);
            string[] Planets = ((IEnumerable<string>)PlanetG.Keys).ToArray(), Areas = areas.Select(x => x.Name).ToArray(), Entities = entities.Select(x => x.Name).ToArray();
            cbPlanets.Items.AddRange(Planets);
            cbAreas.Items.AddRange(Areas);
            cbEntities.Items.AddRange(Entities);
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            double dt = timer.Interval / 1000.0;
            item.Mass = item.Volume * itemDensity;
            Gravity = item.Mass * G;
            Buyoancy = -(areaDensity * G) * item.Volume;
            AddedBuyoancy = -(areaDensity * G) * addedVolume;
            AddedGravity = addedMass * G;
            item.Move(dt, Gravity + Buyoancy + AddedBuyoancy + AddedGravity);
            pbItem.Location = new Point(Convert.ToInt32(item.R.X), Convert.ToInt32(item.R.Y));
            pbBalloon.Top = pbItem.Top - pbBalloon.Height;
            pbWeight.Top = pbItem.Top + pbItem.Height;
            double M = item.Mass + addedMass, V = item.Volume + addedVolume;
            Vector F1 = Gravity + AddedGravity, F2 = Buyoancy + AddedBuyoancy;
            lblMass.Text = "Общая масса: " + M;
            lblVolume.Text = "Общий объём: " + V;
            lblItemDensity.Text = "Плотность тела: " + itemDensity;
            lblAreaDensity.Text = "Плотность среды: " + areaDensity;
            lblGravity.Text = "Сила притяжения: " + F1.Y;
            lblBuyoancy.Text = "Сила Архимеда: " + Math.Abs(F2.Y);
        }

        private void cbPlanets_SelectedIndexChanged(object sender, EventArgs e) => G = new Vector(0, PlanetG[(string)cbPlanets.SelectedItem]);

        private void cbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area area = areas.FirstOrDefault(a => a.Name == cbAreas.SelectedItem.ToString());
            itemDensity = area.Density;
            pnlField.BackColor = area.Color;
        }

        private void cbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity entity = entities.FirstOrDefault(a => a.Name == cbEntities.SelectedItem.ToString());
            itemDensity = entity.Density;
            pbItem.Image = Image.FromFile(entity.Image);
        }

        private void button_Click(object sender, EventArgs e) => timer.Start();

        private void tbAddedVolume_Scroll(object sender, EventArgs e)
        {
            addedVolume = tbAddedVolume.Value == 0 ? 1 : tbAddedVolume.Value;
            pbBalloon.Size = new Size((int)addedVolume, (int)addedVolume);
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            item.Volume = tbVolume.Value == 0 ? 1 : tbVolume.Value;
            pbItem.Size = new Size((int)item.Volume, (int)item.Volume);
        }
        
        private void tbAddedMass_Scroll(object sender, EventArgs e)
        {
            addedMass = tbAddedMass.Value == 0 ? 1 : tbAddedMass.Value;
            pbWeight.Size = new Size((int)addedMass, (int)addedMass);
        }
    }
}