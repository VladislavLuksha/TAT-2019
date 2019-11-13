using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class GlobalCreator
    {
        public List<Faculty> GetFaculties(UniversityCreator universityCreator)
        {
            IDBProvider provider=new DataBaseProviderXml();
            List<Faculty> faculties = universityCreator.FacultyFormation(provider);
            return faculties;
        }

        public List<University> GetUniversity(UniversityCreator universityCreator)
        {
            IDBProvider provider = new DataBaseProviderXml();
            List<University> universities = universityCreator.UniversityFormation(provider);
            return universities;
        }

        public List<Student> GetStudent(UniversityCreator universityCreator)
        {
            IDBProvider provider = new DataBaseProviderXml();
            List<Faculty> faculties = universityCreator.FacultyFormation(provider);
            List<Student> students = new List<Student>(); 
            foreach (Faculty faculty in faculties)
            {
                List<Student> getStudents = faculty.Students;
                foreach(Student student in getStudents)
                {
                    students.Add(student);
                }                
            }
            return students;
        }

        public void PrintListStudent(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Average ball: {student.AverageMark} ");
            }
        }
    }
}
