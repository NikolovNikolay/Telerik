using System;
using System.Linq;

namespace _3.AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, byte age, SexEnum gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Wuf - wuf, i am a dog!");
        }
    }
}
