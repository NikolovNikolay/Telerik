using System;
using System.Linq;

namespace _3.AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, byte age, SexEnum gender)
            :base(name,age,gender)
        {

        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Some noise");
        }
    }
}
