using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Animals
{
    public enum Gender {M,F}

    public abstract class Animal : ISoundProducible
    {
        private Gender gender;
   
        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public void ProduceSound()
        {
            
        }
    }
}
