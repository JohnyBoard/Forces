namespace Forces
{
    public abstract class Materia
    {
        protected Materia(string name, double density)
        {
            Name = name;
            Density = density;
        }

        public string Name { get; set; }

        public double Density { get; set; }
    }
}