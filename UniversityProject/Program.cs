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
            IDBProvider provider = new DataBaseProviderXml();
            UniversityCreator universityCreator = new UniversityCreator();
            GlobalCreator globalCreator = new GlobalCreator();
            List<Faculty> faculties = globalCreator.GetFaculties(universityCreator);
            List<University> university = globalCreator.GetUniversity(universityCreator);
            List<Student> students = globalCreator.GetStudent(universityCreator);
            students.Sort();
            globalCreator.PrintListStudent(students);
            students.Sort(new StudentComparer());
            globalCreator.PrintListStudent(students);
            Console.WriteLine();
            


            IDBProvider providerJson = new DataBaseProviderJson();
            providerJson.GetStudents();            
        }
    }
}
