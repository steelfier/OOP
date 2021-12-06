using System;
using zoo.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    public abstract class Animal
    {
        public string Voice { get; set; }
        public double Weight { get; set; }
        public Colour Colour { get; set; }
        public void GetVoice()
        {
            Console.WriteLine($"{this.GetType().Name} say: {this.Voice}");
        }
        public void Mooving(int a)
        {
            Console.WriteLine($"{this.GetType().Name} moove to {(Side)a}");
        }
        
    }
}
