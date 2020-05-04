using System;

namespace Animals
{
    public class Rat : Animal, ITame
    {
        public string Name { get; set; }
        public Rat(string Name)
        {
            this.Name = Name;
        }
        public string TalkToOwner()
        {
            return "Squeek!";
        }
        public override string MakeSound()
        {
            return "Squeek!";
        }
        public string ComeHere()
        {
            return this.Name + " came to the owner.";
        }
        public void GiveName(string newName)
        {
            this.Name = newName;
        }
    }
}