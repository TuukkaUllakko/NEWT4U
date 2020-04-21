using System;

namespace Animals
{
    public class Bird : Animal, ITame
    {
        public string Name { get; set; }
        public Bird(string Name)
        {
            this.Name = Name;
        }
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
            return this.Name + " came to the owner.";
        }

    }

}