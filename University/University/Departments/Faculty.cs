using System;
using System.Collections.Generic;

namespace University
{
    [Serializable]
    public class Faculty:Department
    {
        public List<Student> students { get; set; }
        public Dean Dean { get; set; }
        int numberOfStudents = 10;
        public delegate void Message(string message);
        public event Message myEvent;

        public Faculty() : base() {  }
        public Faculty(Address address, string name,Dean dean):base(address,name)
        {
            this.Dean = dean;
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
                    myEvent?.Invoke($"Student was add in faculty : {student.Name},{student.Surname},{student.AverageMark}");
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
            return base.ToString() + " " + this.Dean.ToString() + " " + students.ToString();
        }
    }
}
