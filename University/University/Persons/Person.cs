using System;
using System.Collections.Generic;

namespace University
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Person() { }
        public override bool Equals(object subject)
        {
            if (subject is Person)
            {
                Person student = (Person)subject;
                return (this.Name == student.Name && this.Surname == student.Surname);
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.Name + " " + " " + this.Surname;
        }
    }
}
