using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Forces
{
    public partial class Forces : Form
    {
        public Vector Gravity, Buyoancy, R = 0, V, AddedBuyoancy, AddedGravity, G = new Vector(0, 981);
        public double areaDensity = 1, itemDensity = 1, addedVolume = 0, addedMass = 0;
        Item item;
        Dictionary<string, int> PlanetG = new Dictionary<string, int>
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
        Entity[] entities =
        {
            new Entity("Золото", 1930, @"Images\Gold.png"),
            new Entity("Свинец", 1130, @"Images\Lead.png"),
            new Entity("Серебро", 1050, @"Images\Silver.png"),
            new Entity("Фарфор", 2300, @"Images\Porcelain.png"),
            new Entity("Лёд", 9000, @"Images\Ice.png"),
            new Entity("Кирпич", 1800, @"Images\Brick.png"),
            new Entity("Платина", 23500, @"Images\Platinum.png"),
            new Entity("Алмаз", 3510, @"Images\Diamond.png"),           
            new Entity("Гипс", 2787, @"Images\Gypsum.png"),            
            new Entity("Янтарь", 1100, @"Images\Amber.png"),
            new Entity("Уголь", 1450, @"Images\Coal.png"),
            new Entity("Масло", 865, @"Images\Butter.png"),
            new Entity("Латунь", 8500, @"Images\Brass.png"),
            new Entity("Кварц", 2650, @"Images\Quarz.png")
        };
        Area[] areas = 
        {
            new Area("Мёд", 1350, Color.Yellow),
            new Area("Ртуть", 13600, Color.Gray),
            new Area("Вода", 1000, Color.Aqua),
            new Area("Молоко", 1030, Color.White),
            new Area("Бензин", 900, Color.Violet),
            new Area("Хлор", 3, Color.Lime),
            new Area("Кислород", 1, Color.Transparent),
            new Area("Пиво", 1010, Color.Gold),
            new Area("Нефть", 800, Color.Black),
            new Area("Китовый жир", 925, Color.LightGoldenrodYellow),
            new Area("Льяное масло", 940, Color.Wheat),
            new Area("Подсолнечное масло", 920, Color.Olive),
            new Area("Дизельное топливо", 885, Color.Wheat),
        };

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

        public Forces()
        {
            InitializeComponent();
            item = new Item(R = new Vector(0, 0), V = new Vector(0, 10), 1, 1);
            string[] Planets = ((IEnumerable<string>)PlanetG.Keys).ToArray(), Areas = areas.Select(x => x.Name).ToArray(), Entities = entities.Select(x => x.Name).ToArray();
            cbPlanets.Items.AddRange(Planets);
            cbAreas.Items.AddRange(Areas);
            cbEntities.Items.AddRange(Entities);
        }

        private void timer_Tick_1(object sender, EventArgs e)
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
            lblVolume.Text = "Объем тела: " + item.Volume;
            lblItemDensity.Text = "Плотность тела: " + itemDensity;
            lblAreaDensity.Text = "Плотность среды: " + areaDensity;
            lblItemMass.Text = "Масса тела: " + item.Mass;
            lblArchimed.Text = "Сила тяжести: " + Gravity;
            lblArchimed.Text = "Сила Архимеда: " + Buyoancy;
            timer.Start();
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            item.Volume = tbVolume.Value == 0 ? 1 : tbVolume.Value;
            pbItem.Size = new Size((int)item.Volume, (int)item.Volume);
        }
    }
}