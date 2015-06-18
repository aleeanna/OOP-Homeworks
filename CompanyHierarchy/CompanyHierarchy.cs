using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class CompanyHierarchy
    {
        static void Main()
        {
            Employee johnSmith = new Employee((long)12345, "John", "Smith", 7500,Departments.Accounting);

            Console.WriteLine(johnSmith);
        }
    }
}
