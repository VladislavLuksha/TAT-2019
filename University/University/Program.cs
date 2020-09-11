using System;
using System.Collections.Generic;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBOProvider provider = new DBProviderXml();
            UniversitiesCreator universityCreator = new UniversitiesCreator();
            List<University> universities = new List<University>();
            University BGU = universityCreator.CreatUniversity("BGU");
            University BNTY = universityCreator.CreatUniversity("BNTY");
            universities.Add(BGU);
            universities.Add(BNTY);
            List<Student> students = universityCreator.GetStudents("BGU");
            Student student = new Student("Lena", "Ivanova", 6.5);
            List<Department> faculties = BGU.departments;
            foreach(Faculty faculty in faculties)
            {
                faculty.AddStudent(student);
            }
            universityCreator.PrintStudents("BGU");
            students.Sort();
            universityCreator.PrintStudents("BGU");
            students.Sort(new StudentComparer());
            universityCreator.PrintStudents("BGU");
            universityCreator.SaveUniversities(universities);
            
            DataBaseProviderJson dataBaseProviderJson = new DataBaseProviderJson();
            dataBaseProviderJson.SerelizationUniversityInFile(universities);
            List<University> deselizationUniversities = dataBaseProviderJson.DeselizationUniversityFromFile();

        }
    }
}
