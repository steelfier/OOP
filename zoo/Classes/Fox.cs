using System;

namespace zoo
{
    public class Fox : Animal
    {
        public string Role { get; set; }
        public void Eating<T>(T animal) where T : Animal
        {
            if (this.Weight > animal.Weight / 2)
            {
                animal.GetVoice();
                Console.WriteLine($"{this.GetType().Name} ate a {animal.GetType().Name}.");
                this.Weight += 0.5 * animal.Weight;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} is scared. {this.GetType().Name} run away!");
            }
        }
    }
}
