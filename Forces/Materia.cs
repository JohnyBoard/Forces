namespace Forces
{
    public class Materia : Entity
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