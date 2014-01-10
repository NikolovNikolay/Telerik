using System;
using System.Linq;

namespace _3.AnimalHierarchy
{
    class Frog : Animal, ISound
    {
        public Frog(string name, byte age, SexEnum gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("I am a frog and actually don't know what sound i make!?");
        }
    }
}
