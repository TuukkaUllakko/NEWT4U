using System;
namespace Animals
{
    public class Bear : Animal, IWild
    {
        public int weight { get; set; }
        public Bear()
        {
            this.weight = 300;
        }
        public override string MakeSound()
        {
            return "Roar!";
        }
        public string Hunt()
        {
            Random random = new Random();
            double chance = random.NextDouble();
            if (chance <= 0.6)
            {
                Eat();
                return typeof(Bear).Name + " hunts & finds food. " + typeof(Bear).Name + " now weighs " + this.weight + " kilograms.";
            }
            else
            {
                return typeof(Bear).Name + " hunts & wasn't successful.";
            }
        }
        public override void Eat()
        {
            this.weight += 1;
        }
    }
}