using System;
using System.Linq;

namespace _3.AnimalHierarchy
{
    public class Tomcat : Cat, ISound
    {
        private readonly SexEnum gender;
        
        public Tomcat(string name, byte age, SexEnum gender)
            :base(name, age, gender)
        {
            if (gender == SexEnum.male)
            {
                this.gender = SexEnum.male;
            }
            else
                throw new ArgumentException("Tomcat is can be male only");
        }

        public SexEnum Gender
        {
            get { return this.gender; }
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Myaaaaaau- Myaaaau, I am a tomcat!");
        }

       
    }
}
