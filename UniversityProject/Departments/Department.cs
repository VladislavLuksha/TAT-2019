using System;
using System.Collections.Generic;
using System.Xml;

namespace University
{
    [Serializable]
    public class Department
    {
        public Address Address { get; set; }
        public string Name { get; set; }

        public Department() { }
        public Department(Address adress,string name)
        {
            this.Address = adress;
            this.Name = name;
        }

        public override bool Equals(object subject)
        {
            if(subject is Department)
            {
                Department department = (Department)subject;
                return (this.Name == department.Name && Address.Equals(department.Address));
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return this.Name + " " + this.Address.ToString(); 
        }
    }
}
