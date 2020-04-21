namespace Animals
{
    public class Cat : ITame
    {
        public string TalkToOwner()
        {
            return "Meow!";
        }

        public string MakeSound()
        {
            return "Meow!";
        }

        public string ComeHere()
        {
            return "Cat came to the owner";
        }
    }
}