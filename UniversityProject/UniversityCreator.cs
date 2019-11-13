using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class UniversityCreator
    {
        public List<Faculty> FacultyFormation(IDBProvider provider)
        {
            List<Faculty> faculties = new List<Faculty>();
            List<DBOFaculty> DBOFaculties = provider.GetFaculties();
            List<DBOStudent> DBOStudents = provider.GetStudents();
            List<DBOAddress> DBOAddresses = provider.GetAddresses();
            List<DBODean> dBODeans = provider.GetDean();
            foreach (DBOFaculty DBOFaculty in DBOFaculties)
            {
                Faculty faculty = new Faculty();
                Address address = new Address();
                Dean dean = new Dean();
                Student student = new Student();
                foreach (DBOAddress DBOAddress in DBOAddresses)
                {
                    if (DBOFaculty.AdressID == DBOAddress.AddressId)
                    {
                        address = new Address(DBOAddress.Street, DBOAddress.City, DBOAddress.Building);
                    }
                }
                foreach (DBODean dBODean in dBODeans)
                {
                    if (DBOFaculty.DeanID == dBODean.DeanId)
                    {
                        dean = new Dean(dBODean.Name, dBODean.Surname);
                    }
                }
                faculty = new Faculty(address, DBOFaculty.Name, dean);

                foreach (DBOStudent dBOStudent in DBOStudents)
                {
                    if (DBOFaculty.FacultyID == dBOStudent.FacultyID)
                    {
                        student = new Student(dBOStudent.Name, dBOStudent.Surname, dBOStudent.AverageMark);
                        faculty.AddStudent(student);
                    }
                }
                faculties.Add(faculty);
            }
            return faculties;
        }

        public List<University> UniversityFormation(IDBProvider provider)
        {
            List<University> universities = new List<University>();
            List<DBOUniversity> dBOUniversity = provider.GetUniversities();
            List<DBOAddress> dBOAddresses = provider.GetAddresses();
            University university = new University();
            List<Faculty> faculties = FacultyFormation(provider);
            foreach (DBOUniversity dboUniversity in dBOUniversity)
            {
                Address address = new Address();
                foreach (DBOAddress dBOAddress in dBOAddresses)
                {
                    if (dboUniversity.AddressId == dBOAddress.AddressId)
                    {
                        address = new Address(dBOAddress.Street, dBOAddress.City, dBOAddress.Building);
                    }
                }
                university = new University(dboUniversity.Name, address);
               
                foreach(Faculty faculty in faculties)
                {
                    university.AddDepartment(faculty);
                }
                universities.Add(university);
            }
            return universities;
        }


    }
}
