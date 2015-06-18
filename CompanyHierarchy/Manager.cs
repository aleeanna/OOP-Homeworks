using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Manager : Employee
    {
        public Manager(long id, string firstName, string lastName,decimal salary, Departments department, List<Employee> employeesManaged ) 
            : base(id,firstName,lastName, salary,department)
        {
            if (employeesManaged.Count==0)
            {
                throw new ArgumentNullException("Manager must have at least 1 managed employee!");
            }

            this.ManagedEmployees = employeesManaged;
        }

        public List<Employee> ManagedEmployees { get; set; }
    }
}
