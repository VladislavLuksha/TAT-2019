using System;
using System.Collections.Generic;
using System.Xml;

namespace University
{
    [Serializable]
    public class University
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
        public Address Adress { get; set; }
        int maxDepartment = 10;

        public University() { }
        public University(string name,Address adress)
        {
            this.Name = name;
            this.Adress = adress;
            Departments = new List <Department>();
        }

        public bool AddDepartment(Department department)
        {
            bool check = true;
            if(Departments.Count >= 10)
            {
                return false;
            }
            else
            {
                foreach(Department element in Departments)
                {
                    if(element?.Equals(department) == true)
                    {
                        check = false;
                        break;
                    } 
                }
                if(check==true)
                {
                    Departments.Add(department);
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
            return this.Name + " " + this.Adress; 
        }
        
        
      
    }
}
