using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public abstract class Person
    {
        protected Person(long id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public long ID { get; set; }
    }
}
