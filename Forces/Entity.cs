namespace Forces
{
    public class Entity : Materia
    {
        public Entity(string name, int density, string image) : base(name, density) => Image = image;

        public string Image { get; set; }
    }
}