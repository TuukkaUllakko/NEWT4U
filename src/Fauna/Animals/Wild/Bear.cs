namespace Animals
{
    public class Bear : Animal, IWild
    {
        public override string MakeSound()
        {
            return "Roar!";
        }
        public string Hunt()
        {
            return typeof(Bear).Name + " hunts";
        }
    }
}