using System;

namespace Animals
{
    public class Cat : Animal, ITame
    {
        public string Name { get; set; }
        public Cat(string Name)
        {
            this.Name = Name;
        }
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
            return this.Name + " came to the owner.";
        }
        public void GiveName(string newName)
        {
            this.Name = newName;
        }
    }
}