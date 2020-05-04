namespace Animals
{
    public class Tiger : Animal, IWild
    {
        public int weight { get; set; }
        public Tiger()
        {
            this.weight = 200;
        }
        public override string MakeSound()
        {
            return "Grrr!";
        }
        public string Hunt()
        {
            return typeof(Tiger).Name + " hunts";
        }
    }
}