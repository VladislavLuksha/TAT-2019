using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student firstStudent,Student secondStudent)
        {
            if(firstStudent!=null && secondStudent!=null)
            {
                return firstStudent.Surname.CompareTo(secondStudent.Surname);
            }
            else
            {
                throw new Exception("Error!!!");
            }
        }
    }
}
