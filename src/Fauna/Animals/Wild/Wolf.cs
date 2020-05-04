namespace Animals
{
    public class Wolf : Animal, IWild
    {
        public int weight { get; set; }
        public Wolf()
        {
            this.weight = 35;
        }
        public override string MakeSound()
        {
            return "Howl!";
        }
        public string Hunt()
        {
            return typeof(Wolf).Name + " hunts";
        }
        public override void Eat()
        {
            this.weight += 1;
        }
    }
}