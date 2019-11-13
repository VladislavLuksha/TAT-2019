using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;


namespace University
{
    class UniversitiesCreator
    {
        IDBOProvider provider = new DBProviderXml();

        public University CreatUniversity(string name)
        {
            University university = new University();
            university.Name = name;
            List<Faculty> faculties = provider.GetFaculties(name);
            university.Adress = provider.GetUniversityAdress(name);
            foreach(Faculty faculty in faculties)
            {   
                university.AddDepartment(faculty);
            }
            return university;
        }

        public List<Student> GetStudents(string name)
        {
            List<Faculty> faculties = provider.GetFaculties(name);
            List<Student> students = new List<Student>();
            foreach (Faculty faculty in faculties)
            {
                foreach (Student student in faculty.students)
                {
                    students.Add(student);
                }
            }
            return students;
        }
        public List<Faculty> GetFaculty(string name)
        {
            return provider.GetFaculties(name);

        }

        public void PrintStudents(string name)
        {
            List<Student> students = GetStudents(name);
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }

        public void SaveUniversities(List<University> universities)
        {
            ListDBOObject listDBOObject = provider.GetListDBOObjects(universities);
            XmlSerializer formatter = new XmlSerializer(typeof(ListDBOObject), new XmlRootAttribute("root"));
            using (FileStream fstream = new FileStream(@"C:\Users\User\Proga\c#\project(course)\University\University\FilesXml\save.xml", FileMode.Open))
            {
                formatter.Serialize(fstream, listDBOObject);
            }
        }
    }
}
