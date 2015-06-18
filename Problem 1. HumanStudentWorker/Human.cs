using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.HumanStudentWorker
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string  FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}", this.FirstName, this.LastName);
        }
    }
}
