using System;

namespace Animals
{
    public class Bird : Animal, ITame
    {
        public string TalkToOwner()
        {
            return "Tweet!";
        }

        public override string MakeSound()
        {
            return "Tweet!";
        }
        public string ComeHere()
        {
            return " came to the owner.";
        }

    }

}