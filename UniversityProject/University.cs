using System;
using System.Collections.Generic;
using System.Xml;

namespace University
{
    public class University
    {
        string name;
        List<Department> departments;
        Address adress;
        int maxDepartment = 10;

        public University() { }
        public University(string name,Address adress)
        {
            this.name = name;
            this.adress = adress;
            departments = new List <Department>();
        }

        public bool AddDepartment(Department department)
        {
            bool check = true;
            if(departments.Count >= 10)
            {
                return false;
            }
            else
            {
                foreach(Department element in departments)
                {
                    if(element?.Equals(department) == true)
                    {
                        check = false;
                        break;
                    } 
                }
                if(check==true)
                {
                    departments.Add(department);
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
            return this.name + " " + this.adress; 
        }
        public void AddDepartmentFrom(string fileName)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlReader xml = XmlReader.Create(fileName);
            Department department;
            Address address=new Address();
            Dean person=new Dean();
            string name=null;
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "departments")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        if (childNode.Name == "faculty")
                        {
                            foreach (XmlNode nextNode in childNode.ChildNodes)
                            {
                                if (nextNode.Name == "address")
                                {
                                    string street = "";
                                    string city = "";
                                    string building = "";
                                    foreach (XmlNode thisNode in nextNode.ChildNodes)
                                    {
                                        if (thisNode.Name == "street")
                                        {
                                            street = thisNode.InnerText;
                                        }
                                        if (thisNode.Name == "city")
                                        {
                                            city = thisNode.InnerText;
                                        }
                                        if (thisNode.Name == "building")
                                        {
                                            building = thisNode.InnerText;
                                        }
                                        if (street != "" && city != "" && building != "")
                                        {
                                            address = new Address(street, city, building);
                                        }
                                    }
                                }
                                if (nextNode.Name == "name")
                                {
                                    name = nextNode.InnerText;
                                }
                                if (nextNode.Name == "dean")
                                {
                                    string firstName = "";
                                    string surname = "";
                                    foreach (XmlNode thisNode in nextNode.ChildNodes)
                                    {
                                        if (thisNode.Name == "name")
                                        {
                                            firstName = thisNode.InnerText;
                                        }
                                        if (thisNode.Name == "surname")
                                        {
                                            surname = thisNode.InnerText;
                                        }
                                        if (firstName != "" && surname != "")
                                        {
                                            person = new Dean(firstName, surname);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    department = new Faculty(address, name, person);
                    AddDepartment(department);
                }
            }
        }
      
    }
}
