using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Rabbitn : Animal
    {
        public virtual void Eating<T>(T plant) where T : Plant
        {
            if (plant.Pois == false)
            {
                Console.WriteLine($"{this.GetType().Name} ate a {plant.GetType().Name}.");
                this.Weight += 0.2 * plant.Weight;
            }
            else 
            {
                Console.WriteLine($"{this.GetType().Name} is dead.");
            }
        }
    }
}
