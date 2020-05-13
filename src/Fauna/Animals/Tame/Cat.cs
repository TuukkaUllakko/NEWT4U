using System;

namespace Animals
{
    public class Cat : Animal, ITame
    {
        public string Name { get; set; }
        public int weight { get; set; }
        public Cat()
        {
            this.Name = typeof(Cat).Name;
            this.weight = 3;
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
            return this.Name + " lazily struts to you.";
        }
        public void GiveName(string newName)
        {
            this.Name = newName;
        }
        public override void Eat()
        {
            this.weight += 1;
            Console.WriteLine(this.Name + " eats and now weighs " + this.weight + " kilograms.");
        }
    }
}