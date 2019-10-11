using System;
using System.Collections.Generic;
using System.Xml;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBProvider provider = new DataBaseProviderXml();
            //List<Faculty> faculty=provider.GetFaculties();
            //provider.GetUniversities();
            GlobalManager globalManager = new GlobalManager();
            globalManager.AddStudentsInFaculties(provider);


            University university = new University("BGU", new Address("Octobersky", "Minsk", "number 32"));
            Department department = new Department(new Address("October", "Minsk", "number of 32"), "Ministry of Education of the Republic of Belarus");
            university.AddDepartmentFrom("C:\\Users\\User\\Proga\\c#\\project(course)\\University\\University\\University.xml");
            //(physics as Faculty).AddStudentsFromXml("C:\\Users\\User\\Proga\\c#\\project(course)\\University\\University\\University.xml");
            //Department physics = new Faculty(new Address("Lenina", "Minsk", "number 32"), "Physics", new Dean("Ivan", "Ivanov"));
            Department matematics = new Faculty(new Address("Lenina", "Minsk", "number 32"), "Matematics", new Dean("Ivan", "Ivanov"));
            




            //Department BGU = new Institute(new Address("Lenina", "Minsk", "number 32"), "BGU", new Manager("Ivan", "Ivanov"));
            //Person firstStudent = new Student("Vlad","Ivanov");
            //Person secondStudent = new Student("Kostya","Ivanov");

            //Department lada = new Service(new Address("Serova", "Minsk", "16"), "Service Lada", new Head("Vlad", "Ivanov"));


            Person firstEployee = new Employee("Vasya", "Ivanov");
            Person firstAccountant = new Accountant("VAsu", "Smirnov");
           







            //Console.WriteLine(university.AddDepartment(BGU));
            //Console.WriteLine(university.AddDepartment(physics));
            //Console.WriteLine(university.AddDepartment(matematics));
            //Console.WriteLine(university.AddDepartment(lada));
            //Console.WriteLine((physics as Faculty).AddStudent(firstStudent as Student));
            //Console.WriteLine((physics as Faculty).AddStudent(firstStudent as Student));
            //Console.WriteLine((physics as Faculty).AddStudent(secondStudent as Student));
            //Console.WriteLine((BGU as Institute).AddEmploees(firstEployee as Employee));
            //Console.WriteLine((BGU as Institute).AddEmploees(firstEployee as Employee));
            //Console.WriteLine((lada as Service).AddAccountant(firstAccountant as Accountant));
            //Console.WriteLine((lada as Service).AddAccountant(firstAccountant as Accountant));
            //Console.WriteLine(university.ToString());
            //Console.WriteLine(department.ToString());
           // Console.WriteLine(physics.ToString());
            //Console.WriteLine(BGU.ToString());
            //Console.WriteLine(lada.ToString());
            //Console.WriteLine(matematics.ToString());
        }
    }
}
