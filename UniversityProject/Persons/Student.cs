using System;
using System.Collections.Generic;

namespace University
{
    class Student:Person
    {
        List<int> assessments;

        public Student(string name,string surname):base(name,surname)
        {
          
        }
        public Student() { }
        public override string ToString()
        {
            return base.ToString() + " " + assessments.ToString();
        }

    }
}
