using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace University
{
    [Serializable]
    class Student:Person, IComparable
    {
        public double AverageMark { get; set; }

        public Student(string name,string surname,double averageMark):base(name,surname)
        {
            this.AverageMark = averageMark;
        }
        public Student() { }

        public override string ToString()
        {
            return base.ToString() + " " + AverageMark.ToString();
        }

        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            if (student != null)
            {
                return this.AverageMark.CompareTo(student.AverageMark);
            }
            else
            {
                throw new Exception("Error!!!");
            }
                
        }
    }
}
