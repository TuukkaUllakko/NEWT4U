using System;

namespace Animals
{
    public class Pig : Animal, ITame
    {
        public string Name { get; set; }
        public Pig(string Name)
        {
            this.Name = Name;
        }
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
            return this.Name + " came to the owner.";
        }
    }
}