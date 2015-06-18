using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.HumanStudentWorker
{
    class HumanStudentWorker
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>()
            {
                new Student("Gichka", "Mitreva", "blabla3456"),
                new Student("Mitka", "Pencheva", "ahamz12345"),
                new Student("Stiletka", "Biikova", "opa123"),
                new Student("Pencho", "Vladigerski", "epaiqtaka"),
                new Student("Boris", "Mechkov", "1234567890"),
                new Student("Chereshka", "Tryshkova", "9007036357"),
                new Student("Stancho", "Dignev", "1869153"),
                new Student("Krasiv", "Hubavenkov", "op13152"),
                new Student("Preslav", "Petkov", "92awesome"),
                new Student("Gichka", "Stoicheva", "blaha3456"),
            };

            listOfStudents.OrderBy(student => student.FacultyNumber);

            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student.FirstName + student.LastName + "Faculty number: ", student.FacultyNumber);
            }
          
            var pesho = new Worker("Pesho", "Petkanov", 550.0, 6.0);

            pesho.MoneyPerHour(pesho.WeekSalary, pesho.WorkHoursPerDay);
        }
    }
}
