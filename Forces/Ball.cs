namespace Forces
{
    public class Item
    {
        public Item(Vector r, Vector speed, double mass, double volume)
        {
            R = r;
            Speed = Speed;
            Mass = mass;
            Volume = volume;
        }

        public Vector R { get; set; }

        public Vector Speed { get; set; }
             
        public double Volume { get; set; }

        public double Mass { get; set; }

        public void Move(double dt, Vector F)
        {
                Vector a = F / Mass;
            Speed += a * dt;
            Move(dt);
        }

        public void Move(double dt) => R += Speed * dt;
    }
}