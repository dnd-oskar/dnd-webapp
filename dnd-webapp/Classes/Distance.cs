namespace dndwebapp.Classes
{
    public class Speed
    {
        public Distance WalkingSpeed { get; set; } = new();
        public Distance? ClimbingSpeed { get; set; }
        public Distance? SwimmingSpeed { get; set; }
        public Distance? FlyingSpeed { get; set; }
        public Distance? BurrowingSpeed { get; set; }
    }

    public class Sense
    {
        public Distance? Darkvision { get; set; }
        public Distance? Blindsight { get; set; }
        public Distance? Truesight { get; set; }
        public Distance? Tremorsense { get; set; }
    }

    public class Distance
    {
        public int InFt { get; set; }

        public float InM
        {
            get { return InFt * 3 / 10f; }
            set { InFt = (int) Math.Round(value * 10 / 3); }
        }
    }
}
