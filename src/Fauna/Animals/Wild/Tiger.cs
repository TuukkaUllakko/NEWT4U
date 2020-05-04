using System;
namespace Animals
{
    public class Tiger : Animal, IWild
    {
        public int weight { get; set; }
        public Tiger()
        {
            this.weight = 200;
        }
        public override string MakeSound()
        {
            return "Grrr!";
        }
        public string Hunt()
        {
            Random random = new Random();
            double chance = random.NextDouble();
            if (chance <= 0.6)
            {
                this.weight = this.weight + 1;
                return typeof(Bear).Name + " hunts & finds food. " + typeof(Bear).Name + " now weighs " + this.weight + " kilograms.";
            }
            else
            {
                return typeof(Bear).Name + " hunts & wasn't successful.";
            }
        }
    }
}