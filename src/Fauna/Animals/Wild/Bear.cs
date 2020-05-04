namespace Animals
{
    public class Bear : Animal, IWild
    {
        public int weight { get; set; }
        public Bear()
        {
            this.weight = 300;
        }
        public override string MakeSound()
        {
            return "Roar!";
        }
        public string Hunt()
        {
            return typeof(Bear).Name + " hunts";
        }
        public override void Eat()
        {
            this.weight += 1;
        }
    }
}