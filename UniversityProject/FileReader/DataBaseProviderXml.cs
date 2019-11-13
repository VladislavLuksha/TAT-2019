using System;
using System.Collections.Generic;
using System.Xml;

namespace University
{
    class DataBaseProviderXml:IDBProvider
    {
        const string nameFile = @"C:\Users\User\Proga\c#\project(course)\University\University\FilesXml\University.xml";
        XmlDocument xmlDocument;
        XmlElement xRoot;

        public DataBaseProviderXml()
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(nameFile);
            xRoot = xmlDocument.DocumentElement;
        }

        public List<DBOAddress> GetAddresses()
        {
            List<DBOAddress> dBOAddresses = new List<DBOAddress>();
            foreach (XmlElement xnodeNext in xRoot)
            {
                if (xnodeNext.Name == "addresses")
                {
                    foreach (XmlNode childNodeNext in xnodeNext.ChildNodes)
                    {
                        DBOAddress dBOAddress = new DBOAddress();
                        foreach (XmlNode nextNode in childNodeNext.ChildNodes)
                        {
                            if (nextNode.Name == "AddressId")
                            {
                                dBOAddress.AddressId = Int32.Parse(nextNode.InnerText);
                            }
                            if (nextNode.Name == "street")
                            {
                                dBOAddress.Street = nextNode.InnerText;
                            }
                            if (nextNode.Name == "city")
                            {
                                dBOAddress.City = nextNode.InnerText;
                            }
                            if (nextNode.Name == "building")
                            {
                                dBOAddress.Building = nextNode.InnerText;
                            }
                        }
                        dBOAddresses.Add(dBOAddress);
                    }
                }
            }
            return dBOAddresses;
        }

        public List<DBODean> GetDean()
        {
            List<DBODean> dBODeans = new List<DBODean>();
            foreach (XmlElement xnodeSecond in xRoot)
            {
                if (xnodeSecond.Name == "deans")
                {
                    foreach (XmlNode childNodeSecond in xnodeSecond.ChildNodes)
                    {
                        DBODean dBODean = new DBODean();
                        foreach (XmlNode nextNode in childNodeSecond.ChildNodes)
                        {
                            if (nextNode.Name == "deanId")
                            {
                                dBODean.DeanId= Int32.Parse(nextNode.InnerText);
                            }
                            if (nextNode.Name == "name")
                            {
                                dBODean.Name = nextNode.InnerText;
                            }
                            if (nextNode.Name == "surname")
                            {
                                dBODean.Surname= nextNode.InnerText;
                            }
                        }
                        dBODeans.Add(dBODean);
                    }
                }
            }
            return dBODeans;
        }

        public List<DBOFaculty> GetFaculties()
        {
            List<DBOFaculty> dBOFaculties = new List<DBOFaculty>();
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "departments")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        if (childNode.Name == "faculty")
                        {
                            DBOFaculty dBOFaculty = new DBOFaculty();
                            foreach (XmlNode xmlNode in childNode.ChildNodes)
                            {
                                if (xmlNode.Name == "name")
                                {
                                    dBOFaculty.Name = xmlNode.InnerText;
                                }
                                if (xmlNode.Name == "AddressId")
                                {
                                    dBOFaculty.AdressID = Int32.Parse(xmlNode.InnerText);
                                }
                                if (xmlNode.Name == "deanId")
                                {
                                    dBOFaculty.DeanID = Int32.Parse(xmlNode.InnerText);
                                }
                                if(xmlNode.Name == "FacultyID")
                                {
                                    dBOFaculty.FacultyID = Int32.Parse(xmlNode.InnerText);
                                }
                            }
                            dBOFaculties.Add(dBOFaculty);
                        }
                    }
                }
            }
            return dBOFaculties;
        }

        public List<DBOStudent> GetStudents()
        {
            List<DBOStudent> students = new List<DBOStudent>();
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "students")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        DBOStudent dBOStudent = new DBOStudent();
                        foreach (XmlNode xmlNode in childNode.ChildNodes)
                        {
                            if (xmlNode.Name == "name")
                            {
                                dBOStudent.Name = xmlNode.InnerText;
                            }
                            if (xmlNode.Name == "surname")
                            {
                                dBOStudent.Surname = xmlNode.InnerText;
                            }
                            if (xmlNode.Name == "surname")
                            {
                                dBOStudent.Surname = xmlNode.InnerText;
                            }
                            if (xmlNode.Name == "FacultyID")
                            {
                                dBOStudent.FacultyID = Int32.Parse(xmlNode.InnerText);
                            }
                            if(xmlNode.Name == "averageMark")
                            {
                                dBOStudent.AverageMark = Double.Parse(xmlNode.InnerText);
                            }
                        }
                        students.Add(dBOStudent);
                    }
                }
            }
            return students;
        }

        public List<DBOUniversity> GetUniversities()
        {
            List<DBOUniversity> dBOUniversities = new List<DBOUniversity>();
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "universities")
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        DBOUniversity dBOUniversity = new DBOUniversity();
                        foreach (XmlNode xmlNode in childNode.ChildNodes)
                        {
                            if (xmlNode.Name == "name")
                            {
                                dBOUniversity.Name = xmlNode.InnerText;
                            }
                            if (xmlNode.Name == "AddressId")
                            {
                                dBOUniversity.AddressId = Int32.Parse(xmlNode.InnerText);
                            }
                        }
                        dBOUniversities.Add(dBOUniversity);
                    }
                }
            }
            return dBOUniversities;
        }
    }
}
