namespace Animals
{
    public class Wolf : IWild
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