using System;
using System.Linq;

namespace _3.AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, byte age)
            :base(name,age,SexEnum.female)
        {
            
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Miau - miau, i am a kitten!");
        }
    }
}
