using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender)
            : base(name, age, gender)
        {
            if ((int) this.Gender == 0)
            {
                throw new ArgumentException("Kittens can only be female!");
            }
        }

        public void ProduceSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
