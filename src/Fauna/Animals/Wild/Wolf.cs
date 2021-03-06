using System;
namespace Animals
{
    public class Wolf : Animal, IWild
    {
        public int weight { get; set; }
        public Wolf()
        {
            this.weight = 35;
        }
        public override string MakeSound()
        {
            return "Howl!";
        }
        public string Hunt()
        {
            Random random = new Random();
            double chance = random.NextDouble();
            if (chance <= 0.6)
            {
                Eat();
                return typeof(Wolf).Name + " hunts and finds food. It now weighs " + this.weight + " kilograms.";
            }
            else
            {
                return typeof(Wolf).Name + " hunts but isn't successful and has to go hungry.";
            }
        }
        public override void Eat()
        {
            this.weight += 1;
        }
    }
}