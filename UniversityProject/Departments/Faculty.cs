using System;
using System.Collections.Generic;
using System.Xml;

namespace University
{
    class Faculty:Department
    {
        List <Student> students;
        Dean dean;
        int numberOfStudents = 10;

        public Faculty(Address address, string name,Dean dean):base(address,name)
        {
            this.dean = dean;
            students = new List<Student>();
        }

        public bool AddStudent(Student student)
        {
            bool check = true;
            if (numberOfStudents <= students.Count)
            {
                return false;
            }
            else
            {
                foreach (Student element in students)
                {
                    if (element?.Equals(student) == true)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    students.Add(student);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.dean.ToString() + " " + students.ToString();
        }
        
        public void AddStudentsFromXml(string fileName)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            Student student;
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "students")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        string name = "";
                        string surname = "";
                        foreach (XmlNode xmlNode in childNode.ChildNodes)
                        {
                            if (xmlNode.Name == "name")
                            {
                                name = xmlNode.InnerText;
                            }
                            if (xmlNode.Name == "surname")
                            {
                                surname = xmlNode.InnerText;
                            }
                            if (name != "" && surname != "")
                            {
                                student = new Student(name, surname);
                                AddStudent(student);
                            }
                        }
                    }
                }
            }
        }
    }
}
