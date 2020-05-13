using System;

namespace Animals
{
    public class Dog : Animal, ITame
    {
        public string Name { get; set; }
        public int weight { get; set; }
        public Dog()
        {
            this.Name = typeof(Dog).Name;
            this.weight = 45;
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
            return this.Name + " wags its tail and comes running to you!";
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