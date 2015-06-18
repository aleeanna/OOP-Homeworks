using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Animals
{
    class Animals
    {
        static void Main()
        {
            Dog barkingDog = new Dog("Peicho",2,Gender.M);
            barkingDog.ProduceSound();

            Cat meowCat = new Cat("Mistery",1,Gender.F);
            meowCat.ProduceSound();

            Frog quackFrog = new Frog("Krastav",2,Gender.M);
            quackFrog.ProduceSound();

            Kitten kitty = new Kitten("Misty",0,Gender.F); 
            kitty.ProduceSound();

            Tomcat tommy = new Tomcat("Tommy",1,Gender.M);
            tommy.ProduceSound();

            IList<Animal> animals = new List<Animal>()
            {
                new Dog("Sharo", 3,Gender.M),
                new Dog("Pesho", 2,Gender.M),
                new Dog("Minka", 1,Gender.F),
                new Dog("Mincho", 2,Gender.M),
                new Cat("Dina", 5,Gender.F),
                new Cat("Mina", 1,Gender.F),
                new Cat("Karolina", 3,Gender.F),
                new Cat("Munio", 2,Gender.M),
                new Cat("Stamat", 1,Gender.M),
                new Frog("ManiakaKvakaMothefucka", 1,Gender.F),
                new Kitten("Evlampia", 3,Gender.F),
                new Tomcat("Evlampi", 5,Gender.M)
            };

            var groupedAnimals =
                animals.GroupBy(animal => animal.GetType());

            foreach (var group in groupedAnimals)
            {
                Console.WriteLine("The average age of {0} is {1}", group.Key,group.Average(animal => animal.Age));           
            }
        }
    }
}
