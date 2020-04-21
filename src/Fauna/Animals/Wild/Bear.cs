namespace Animals
{
    public class Bear : IWild
    {
        public string MakeSound()
        {
            return "Growl";
        }
        public string Hunt()
        {
            return "Bear hunts";
        }
    }
}