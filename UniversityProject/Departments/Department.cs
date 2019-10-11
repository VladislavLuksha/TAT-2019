using System;
using System.Collections.Generic;
using System.Xml;

namespace University
{
    public class Department
    {
        Address address;
        string name;

        public Department(Address adress,string name)
        {
            this.address = adress;
            this.name = name;
        }

        public override bool Equals(object subject)
        {
            if(subject is Department)
            {
                Department department = (Department)subject;
                return (this.name == department.name && address.Equals(department.address));
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return this.name + " " + this.address.ToString(); 
        }
    }
}
