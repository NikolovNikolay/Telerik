using System;
using System.Linq;

namespace _3.AnimalHierarchy
{
    public class Tomcat : Cat, ISound
    {
        
        public Tomcat(string name, byte age)
            :base(name, age, SexEnum.male)
        {
            
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Myaaaaaau- Myaaaau, I am a tomcat!");
        }

       
    }
}
