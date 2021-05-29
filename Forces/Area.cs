using System.Drawing;

namespace Forces
{
    public class Area : Materia
    {
        public Area(string name, double density, Color color) : base(name, density) => Color = color;

        public Color Color { get; set; }
    }
}