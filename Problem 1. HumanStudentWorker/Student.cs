using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Problem_1.HumanStudentWorker;

namespace Problem_1.HumanStudentWorker
{

    class Student: Human
    {
        private const int MinFacultyNumberLenght = 5;
        private const int MaxFacultyNumberLenght = 10;


        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length<MinFacultyNumberLenght || value.Length>MaxFacultyNumberLenght)
                {
                    throw new ArgumentOutOfRangeException("Faculty number must contain 5-10 digits or letters!");
                }
                this.facultyNumber = value;
            }
        }
    }
}
