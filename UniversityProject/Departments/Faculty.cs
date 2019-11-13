using System;
using System.Collections.Generic;
using System.Xml;

namespace University
{
    [Serializable]
    class Faculty:Department
    {
        public List<Student> Students { get; set; }
        public Dean Dean { get; set; }
        int numberOfStudents = 10;

        public Faculty() : base() { }
        public Faculty(Address address, string name,Dean dean):base(address,name)
        {
            this.Dean = dean;
            Students = new List<Student>();
        }

        public bool AddStudent(Student student)
        {
            bool check = true;
            if (numberOfStudents <= Students.Count)
            {
                return false;
            }
            else
            {
                foreach (Student element in Students)
                {
                    if (element?.Equals(student) == true)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    Students.Add(student);
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
            return base.ToString() + " " + this.Dean.ToString() + " " + Students.ToString();
        }
    }
}
