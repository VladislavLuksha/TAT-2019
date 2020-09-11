using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace University
{
    class DBProviderXml : IDBOProvider
    {
        XDocument xDocument;
        int counterAddresses = 0;
        int counterFaculties = 0;
        int counterUniversities = 0;
        int counterDeans = 0;

        public DBProviderXml()
        {
            xDocument = XDocument.Load("C:\\Users\\User\\Proga\\c#\\project(course)\\University\\University\\FilesXml\\University.xml");
        }

        public List<Faculty> GetFaculties(string name)
        {
            List<DBOFaculty> listDBOfaculty = GetDBOFaculty(name);
            List<Faculty> faculties = new List<Faculty>();
            Faculty faculty;
            foreach (DBOFaculty element in listDBOfaculty)
            {
                Address address = GetAddress(element.AdressID);
                Dean dean = GetDean(element.FacultyID);
                faculty = new Faculty(address, element.Name, dean);
                List<Student> students = GetStudents(element.FacultyID);
                foreach (Student student in students)
                {
                    faculty.AddStudent(student);
                }
                faculties.Add(faculty);
            }
            return faculties;
        }
        public List<DBOFaculty> GetDBOFaculty(string name)
        {
            return (from xe in xDocument.Root.Element("departments").Elements("faculty")
                    where Int32.Parse(xe.Element("universityId").Value) == GetIDUniversity(name)
                    select new DBOFaculty()
                    {
                        Name = xe.Element("name").Value,
                        FacultyID = Int32.Parse(xe.Element("FacultyID").Value),
                        AdressID = Int32.Parse(xe.Element("AddressId").Value)
                    }).ToList();
        }
        public Dean GetDean(int id)
        {
            return (from xe in xDocument.Root.Element("deans").Elements("dean")
                        where Int32.Parse(xe.Element("deanId").Value) == id
                        select new Dean
                        {
                            Name = xe.Element("name").Value,
                            Surname = xe.Element("surname").Value
                        }).First();
        }
        public List<Student> GetStudents(int id)
        {
            return (from xe in xDocument.Root.Element("students").Elements("student")
                    where Int32.Parse(xe.Element("FacultyID").Value) == id
                    select new Student
                    {
                        Name = xe.Element("name").Value,
                        Surname = xe.Element("surname").Value,
                        AverageMark = Double.Parse(xe.Element("averageMark").Value)
                    }).ToList();
        }
        public int GetIDUniversity(string name)
        {
            return (from xe in xDocument.Root.Element("universities").Elements("university")
                       where xe.Element("name").Value == name
                       select Int32.Parse(xe.Element("universityId").Value)).First();       
        }
        public Address GetUniversityAdress(string name)
        {
            Address address = GetAddress(GetIDUniversity(name));
            return address;
        }
        public Address GetAddress(int id)
        {
            return (from xe in xDocument.Root.Element("addresses").Elements("address")
                      where Int32.Parse(xe.Element("AddressId").Value) == id
                      select new Address
                      {
                          Street = xe.Element("street").Value,
                          Building = xe.Element("building").Value,
                          City = xe.Element("city").Value
                      }).First();
        }

        public List<DBOAddress> CreatedDBOAddress(List<University> universities)
        {
            counterAddresses = 0;
            var dboAddress = (from dboUniversity in universities
                       select new DBOAddress
                       {
                           Building = dboUniversity.Adress.Building,
                           City = dboUniversity.Adress.City,
                           Street = dboUniversity.Adress.Street,
                           AddressId = counterAddresses++
                       }).ToList();
            foreach(University university in universities)
            {
                var dboAddressFaculty = (from dboUniversity in university.departments
                         select new DBOAddress
                         {
                             Building = dboUniversity.Address.Building,
                             City = dboUniversity.Address.City,
                             Street = dboUniversity.Address.Street,
                             AddressId = counterAddresses++
                         }).ToList();
                foreach(var dBOAddress in dboAddressFaculty)
                {
                    dboAddress.Add(dBOAddress);
                }
            }
            return dboAddress;
        }
        public List<DBOUniversity> CreatedDBOUniversities(List<University> universities)
        {
            counterUniversities = 0;
            List<DBOAddress> dBOAddresses = CreatedDBOAddress(universities);
            return (from university in universities
                         from adress in dBOAddresses
                         where university.Adress.City == adress.City && university.Adress.Building == adress.Building && university.Adress.Street == adress.Street
                         select new DBOUniversity
                         {
                             Name = university.Name,
                             AddressId = adress.AddressId,
                             UniversityId = counterUniversities++
                         }).ToList();
        }
        public List<DBOFaculty> CreatedDBOFaculties(List<University> universities)
        {
            counterFaculties = 0;
            List<DBOAddress> dBOAddresses = CreatedDBOAddress(universities);
            List<DBOUniversity> dBOUniversities = CreatedDBOUniversities(universities);
            return (from university in universities
                                from dboUniversity in dBOUniversities
                                from dboFaculty in university.departments
                                from dboAddress in dBOAddresses
                               where dboAddress.City==dboFaculty.Address.City && dboAddress.Building==dboFaculty.Address.Building && dboAddress.Street==dboFaculty.Address.Street && dboUniversity.Name==university.Name
                             select new DBOFaculty
                             {
                                 Name = dboFaculty.Name,
                                 FacultyID = counterFaculties++,
                                 AdressID = dboAddress.AddressId,
                                 UniversityID =dboUniversity.UniversityId
                             }).ToList();
         }
        public List<DBODean> CreatedDBODean(List<University> universities)
        {
            counterDeans = 0;
            return  (from university in universities
                    from departament in university.departments
                    let faculty = (Faculty)departament
                    select new DBODean
                    {
                        Name = faculty.Dean.Name,
                        Surname = faculty.Dean.Surname,
                        DeanId = counterDeans++
                    }).ToList();
        }
        public List<DBOStudent> CreatedDBOStudent(List<University> universities)
        {
            List<DBOFaculty> dBOFaculty = CreatedDBOFaculties(universities);
            return  (from university in universities
                    from dboFaculty in dBOFaculty
                    from departament in university.departments
                    let faculty = (Faculty)departament
                    from student in faculty.students
                    where dboFaculty.Name == departament.Name
                    select new DBOStudent
                    {
                        Name = student.Name,
                        Surname= student.Surname,
                        AverageMark=student.AverageMark,
                        FacultyID=dboFaculty.FacultyID
                    }).ToList();
        }
        public ListDBOObject GetListDBOObjects(List<University> universities)
        {
            ListDBOObject listDBOObject = new ListDBOObject();
            listDBOObject.dBOAddresses = CreatedDBOAddress(universities);
            listDBOObject.dBODeans = CreatedDBODean(universities);
            listDBOObject.dBOFaculties = CreatedDBOFaculties(universities);
            listDBOObject.dBOStudents = CreatedDBOStudent(universities);
            listDBOObject.dBOUniversities = CreatedDBOUniversities(universities);
            return listDBOObject;
        }
    }
}
