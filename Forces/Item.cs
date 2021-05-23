namespace Forces
{
    public class Item
    {
        public Item(Vector r, Vector speed, int mass, int volume)
        {
            R = r;
            Speed = Speed;
            Mass = mass;
            Volume = volume;
        }

        public Vector R { get; set; }

        public Vector Speed { get; set; }

        public int Volume { get; set; }

        public int Mass { get; set; }

        public void Move(int dt, Vector F)
        {
            Vector a = F / Mass;
            Speed += a * dt;
            Move(dt);
        }

        public void Move(int dt) => R += Speed * dt;
    }
}