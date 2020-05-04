using System;

namespace Animals
{
    public class Dog : Animal, ITame
    {
        public string Name { get; set; }
        public Dog()
        {
            this.Name = Name;
        }
        public string TalkToOwner()
        {
            return "Woof!";
        }
        public override string MakeSound()
        {
            return "Woof!";
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