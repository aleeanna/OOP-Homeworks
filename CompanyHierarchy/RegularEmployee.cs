using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(long id, string firstName, string lastName,decimal salary, Departments department) 
            : base(id,firstName,lastName,salary,department)
        {
           
        }
    }
}
