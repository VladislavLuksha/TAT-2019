using System;
using System.Collections.Generic;

namespace University
{
    class Person
    {
        string name;
        string surname;

        public Person(string name,string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Person() { }
        public override bool Equals(object subject)
        {
            if (subject is Person)
            {
                Person student = (Person)subject;
                return (this.name == student.name && this.surname == student.surname);
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.name + " " + " " + this.surname;
        }
    }
}
