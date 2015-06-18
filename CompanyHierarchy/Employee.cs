using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public enum Departments
    {
        Production,
        Accounting,
        Sales,
        Marketing
    };

    public class Employee : Person
    {
        public Employee(long id, string firstName, string lastName,decimal salary, Departments department) 
            : base(id,firstName,lastName)
        {
            if ((int)this.Department<0 || (int)this.Department>3)
            {
                throw new ArgumentOutOfRangeException("Invalid department! Please pick one of the 4 departments!");
            }
            this.Salary = salary;
            this.Department = department;
        }

        public Departments Department { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return string.Format("Employee ID: {0}\nFirst name: {1}\nLast name: {2}\nSalary: {3}\nDepartment: {4}",
                this.ID, this.FirstName, this.LastName, this.Salary, this.Department);
        }
    }
}
