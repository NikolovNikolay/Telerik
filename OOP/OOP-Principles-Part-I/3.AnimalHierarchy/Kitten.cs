using System;
using System.Linq;

namespace _3.AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        private readonly SexEnum gender;

        public Kitten(string name, byte age, SexEnum gender)
            :base(name,age,gender)
        {
            if (gender == SexEnum.female)
            {
                this.gender = gender;
            }
            else
            {
                throw new ArgumentException("Kittens are female only");
            }
        }

        public SexEnum Gender
        {
            get { return this.gender; }
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Miau - miau, i am a kitten!");
        }
    }
}
