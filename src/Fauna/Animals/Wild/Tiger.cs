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
                Eat();
                return typeof(Tiger).Name + " hunts and finds food. It now weighs " + this.weight + " kilograms.";
            }
            else
            {
                return typeof(Tiger).Name + " isn't successful in the hunt and has to go hungry.";
            }
        }
        public override void Eat()
        {
            this.weight += 1;
        }
    }
}