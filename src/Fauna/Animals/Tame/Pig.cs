using System;

namespace Animals
{
    public class Pig : Animal, ITame
    {
        public string Name { get; set; }
        public int weight { get; set; }
        public Pig()
        {
            this.Name = Name;
            this.weight = 85;
        }
        public string TalkToOwner()
        {
            return "Oink!";
        }

        public string ComeHere()
        {
            return this.Name + " came to the owner.";
        }

        public override string MakeSound()
        {
            return "Oink!";
        }
        public void GiveName(string newName)
        {
            this.Name = newName;
        }
        public override void Eat()
        {
            this.weight += 1;
            Console.WriteLine(this.Name + " now weighs " + this.weight + " kilograms.");
        }
    }
}