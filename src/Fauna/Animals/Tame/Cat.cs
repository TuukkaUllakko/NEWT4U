using System;

namespace Animals
{
    public class Cat : Animal, ITame
    {
        public string TalkToOwner()
        {
            return "Meow!";
        }

        public override string MakeSound()
        {
            return "Meow!";
        }

        public string ComeHere()
        {
            return " came to the owner.";
        }
    }
}