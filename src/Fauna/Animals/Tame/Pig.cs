using System;

namespace Animals
{
    public class Pig : Animal, ITame
    {
        public string TalkToOwner()
        {
            return "Oink!";
        }
        public override string MakeSound()
        {
            return "Oink!";
        }
        public string ComeHere()
        {
            return " came to the owner.";
        }
    }
}