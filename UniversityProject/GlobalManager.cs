using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class GlobalManager
    {
        public List<Faculty> AddStudentsInFaculties(IDBProvider provider)
        {
            List<Faculty> faculties = provider.GetFaculties();
            List<Student> students = provider.GetStudents();
            List<int> IDfaculties = provider.IDfaculty();
            List<int> IDstudents = provider.IDStudent();
            IDfaculties.Sort();
            IDstudents.Sort();
            foreach(Faculty faculty in faculties)
            {
                foreach(Student student in students)
                {

                }
            }
            return faculties;
        }

    }
}
