namespace Forces
{
    public abstract class Materia
    {
        protected Materia(string name, int density)
        {
            Name = name;
            Density = density;
        }

        public string Name { get; set; }

        public int Density { get; set; }
    }
}