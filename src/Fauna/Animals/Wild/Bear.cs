namespace Animals
{
    public class Bear : Animal, IWild
    {
        public override string MakeSound()
        {
            return "Growl!";
        }
        public string Hunt()
        {
            return typeof(Bear).Name + " hunts";
        }
    }
}