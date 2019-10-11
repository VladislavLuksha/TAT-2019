using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace University
{
    class DataBaseProviderXml:IDBProvider
    {
        const string nameFile = "C:\\Users\\User\\Proga\\c#\\project(course)\\University\\University\\University.xml";
        XmlDocument xmlDocument;
        XmlElement xRoot;
        public DataBaseProviderXml()
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(nameFile);
            xRoot = xmlDocument.DocumentElement;
        }

        public List<Address> GetAddresses()
        {
            
        }

        public List<Faculty> GetFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            Faculty faculty;
            Address address = new Address();
            Dean dean = new Dean();
            string name="";
            int deanID = 0;
            int addressID = 0;
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "departments")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        if (childNode.Name == "faculty")
                        {
                            foreach (XmlNode xmlNode in childNode.ChildNodes)
                            {
                                if (xmlNode.Name == "name")
                                {
                                    name = xmlNode.InnerText;
                                }
                                if (xmlNode.Name == "AddressId")
                                {
                                    addressID = Int32.Parse(xmlNode.InnerText);
                                }
                                if (xmlNode.Name == "deanId")
                                {
                                    deanID = Int32.Parse(xmlNode.InnerText);
                                }
                            }
                        }
                        foreach (XmlElement xnodeNext in xRoot)
                        {
                            if (xnodeNext.Name == "addresses")
                            {
                                foreach (XmlNode childNodeNext in xnodeNext.ChildNodes)
                                {
                                    int addressId = 0;
                                    string street = "";
                                    string city = "";
                                    string building = "";
                                    foreach (XmlNode nextNode in childNodeNext.ChildNodes)
                                    {
                                        if (nextNode.Name == "AddressId")
                                        {
                                            addressId = Int32.Parse(nextNode.InnerText);
                                        }
                                        if (addressId == addressID)
                                        {
                                            if (nextNode.Name == "street")
                                            {
                                                street = nextNode.InnerText;
                                            }
                                            if (nextNode.Name == "city")
                                            {
                                                city = nextNode.InnerText;
                                            }
                                            if (nextNode.Name == "building")
                                            {
                                                building = nextNode.InnerText;
                                            }
                                            if (street != "" && city != "" && building != "")
                                            {
                                                address = new Address(street, city, building);
                                            }
                                        }
                                    }
                                }
                            }    
                        }
                        foreach (XmlElement xnodeSecond in xRoot)
                        {
                            if (xnodeSecond.Name == "deans")
                            {
                                foreach (XmlNode childNodeSecond in xnodeSecond.ChildNodes)
                                {
                                    int deanId = 0;
                                    string nameDean = "";
                                    string surnameDean = "";
                                    foreach (XmlNode nextNode in childNodeSecond.ChildNodes)
                                    {
                                        if (nextNode.Name == "deanId")
                                        {
                                            deanId = Int32.Parse(nextNode.InnerText);
                                        }
                                        if (deanID == deanId)
                                        {
                                            if (nextNode.Name == "name")
                                            {
                                                nameDean = nextNode.InnerText;
                                            }
                                            if (nextNode.Name == "surname")
                                            {
                                                surnameDean = nextNode.InnerText;
                                            }

                                            if (nameDean != "" && surnameDean != "")
                                            {
                                                dean = new Dean(nameDean, surnameDean);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (address != null && dean != null && name != null)
                        {
                            faculty = new Faculty(address, name, dean);
                            faculties.Add(faculty);
                        }
                    }
                }
            }
            return faculties;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            Student student = new Student();
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "students")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        string name = "";
                        string surname = "";
                        foreach (XmlNode xmlNode in childNode.ChildNodes)
                        {
                            if (xmlNode.Name == "name")
                            {
                                name = xmlNode.InnerText;
                            }
                            if (xmlNode.Name == "surname")
                            {
                                surname = xmlNode.InnerText;
                            }
                            if (name != "" && surname != "")
                            {
                                student = new Student(name, surname);
                                students.Add(student);
                            }
                        }
                    }
                }
            }
            return students;
        }

        public List<University> GetUniversities()
        {
            List<University> universities = new List<University>();
            University university = new University();
            Address address = new Address();
            string nameUniversity = "";
            int addressID = 0;
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "universities")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        foreach (XmlNode xmlNode in childNode.ChildNodes)
                        {
                            if (xmlNode.Name == "name")
                            {
                                nameUniversity = xmlNode.InnerText;
                            }
                            if (xmlNode.Name == "AddressId")
                            {
                                addressID = Int32.Parse(xmlNode.InnerText);
                            }
                        }
                        foreach (XmlElement xnodeNext in xRoot)
                        {
                            if (xnodeNext.Name == "addresses")
                            {
                                foreach (XmlNode childNodeNext in xnodeNext.ChildNodes)
                                {
                                    int addressId = 0;
                                    string street = "";
                                    string city = "";
                                    string building = "";
                                    foreach (XmlNode nextNode in childNodeNext.ChildNodes)
                                    {
                                        if (nextNode.Name == "AddressId")
                                        {
                                            addressId = Int32.Parse(nextNode.InnerText);
                                        }
                                        if (addressId == addressID)
                                        {
                                            if (nextNode.Name == "street")
                                            {
                                                street = nextNode.InnerText;
                                            }
                                            if (nextNode.Name == "city")
                                            {
                                                city = nextNode.InnerText;
                                            }
                                            if (nextNode.Name == "building")
                                            {
                                                building = nextNode.InnerText;
                                            }
                                            if (street != "" && city != "" && building != "")
                                            {
                                                address = new Address(street, city, building);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if(address!=null && nameUniversity!=null)
                        {
                            university = new University(nameUniversity, address);
                            universities.Add(university);
                        }
                    }
                }
            }
            return universities;
        }


        public List<int> IDfaculty()
        {
            List<int> IDfaculty = new List<int>();
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "departments")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        int Idfaculty = 0;
                        if (childNode.Name == "faculty")
                        {
                            foreach (XmlNode xmlNode in childNode.ChildNodes)
                            {
                                if (xmlNode.Name == "FacultyID")
                                {
                                    Idfaculty = Int32.Parse(xmlNode.InnerText);
                                    IDfaculty.Add(Idfaculty);
                                }
                            }
                        }
                    }
                }
            }
            return IDfaculty;
        }

        public List<int> IDStudent()
        {
            List<int> IdStudents = new List<int>();
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "students")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        int StudentsID = 0;
                        foreach (XmlNode xmlNode in childNode.ChildNodes)
                        {
                            if(xmlNode.Name== "FacultyID")
                            {
                                StudentsID = Int32.Parse(xmlNode.InnerText);
                                IdStudents.Add(StudentsID);
                            }
                        }
                    }
                }
            }
            return IdStudents;
        }
    }
}
