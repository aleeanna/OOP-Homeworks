using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Animals
{
   public class Tomcat : Cat
    {
       public Tomcat(string name, int age, Gender gender)
           : base(name, age, gender)
       {
           if ((int)this.Gender == 1)
           {
               throw new ArgumentException("Tomcats can only be male!");
           }
       }

       public void ProduceSound()
       {
           Console.WriteLine("Meow!");
       }
    }
}
