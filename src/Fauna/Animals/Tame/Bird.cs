using System;

namespace Animals
{
    public class Bird : Animal, ITame
    {
        public string Name { get; set; }
        public int weight { get; set; }
        public Bird()
        {
            this.Name = typeof(Bird).Name;
            this.weight = 1;
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
            return this.Name + " comes flying to you.";
        }
        public void GiveName(string newName)
        {
            this.Name = newName;
        }
        public override void Eat()
        {
            this.weight += 1;
            Console.WriteLine(this.Name + " eats and suddenly weighs " + this.weight + " kilograms!");
        }
    }
}