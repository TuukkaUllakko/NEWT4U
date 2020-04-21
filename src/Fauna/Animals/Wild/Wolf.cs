namespace Animals
{
    public class Wolf : Animal, IWild
    {
        public string MakeSound()
        {
            return "Hooooowwwwwwwl";
        }
        public string Hunt()
        {
            return "Wolf hunts";
        }
    }
}