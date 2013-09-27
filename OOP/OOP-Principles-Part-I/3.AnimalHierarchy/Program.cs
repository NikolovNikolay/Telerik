/* 3. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define
 *    useful constructors and methods. Dogs, frogs and cats are Animals.
 *    All animals can produce sound (specified by the ISound interface). 
 *    Kittens and tomcats are cats. All animals are described by age, name 
 *    and sex. Kittens can be only female and tomcats can be only male. Each 
 *    animal produces a specific sound. Create arrays of different kinds of 
 *    animals and calculate the average age of each kind of animal using a 
 *    static method (you may use LINQ).
*/

using System;
using System.Linq;

namespace _3.AnimalHierarchy
{
    class Program
    {
        static void Main()
        {
            Kitten kitty = new Kitten("kjfl", 1, SexEnum.female);
            Tomcat tomas = new Tomcat("fgfv", 2, SexEnum.male);
            Dog sharo = new Dog("fvdv", 3, SexEnum.male);
            Frog squeek = new Frog("vfdv", 1, SexEnum.female);
            kitty.MakeSomeNoise();
            tomas.MakeSomeNoise();
            sharo.MakeSomeNoise();
            squeek.MakeSomeNoise();

            Animal[] animals = 
            {
                new Kitten("fgvgfg",2,SexEnum.female),
                new Tomcat("vfvfdv",4,SexEnum.male),
                new Dog("vfdfv",5,SexEnum.female),
                new Frog("vfvfv",2,SexEnum.female),
                new Kitten("fgvgfg",6,SexEnum.female),
                new Tomcat("vfvfdv",2,SexEnum.male),
                new Dog("vfdfv",7,SexEnum.female),
                new Frog("vfvfv",10,SexEnum.female),
                 new Kitten("fgvgfg",8,SexEnum.female),
                new Tomcat("vfvfdv",8,SexEnum.male),
                new Dog("vfdfv",9,SexEnum.female),
                new Frog("vfvfv",5,SexEnum.female),
            };

            var ordered = animals.GroupBy(x => x.GetType());
            Console.WriteLine();
            foreach (var animal in ordered)
            {
                Console.WriteLine("Average age of {0} is {1:F2}.",animal.Key.Name, animal.Average(x => x.Age));
            }
        }
    }
}
