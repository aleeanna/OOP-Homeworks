using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Developer : RegularEmployee
    {
        public Developer(long id, string firstName, string lastName,decimal salary, Departments department, List<Project> projects ) 
            : base(id,firstName,lastName,salary,department)
        {
            if (this.Projects.Count == 0)
            {
                throw new ArgumentNullException("A developer must have at least one active project listed!");
            }
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }
    }
}
