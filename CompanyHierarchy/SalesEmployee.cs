using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class SalesEmployee : RegularEmployee
    {
        public SalesEmployee(long id, string firstName, string lastName,decimal salary, Departments department, List<Sale> sales ) 
            : base(id,firstName,lastName,salary,department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }
    }
}
