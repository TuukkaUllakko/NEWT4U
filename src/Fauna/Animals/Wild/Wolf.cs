namespace Animals
{
    public class Wolf : Animal, IWild
    {
        public override string MakeSound()
        {
            return "Howl!";
        }
        public string Hunt()
        {
            return typeof(Wolf).Name + " hunts";
        }
    }
}