using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface IDBOProvider
    {
        int GetIDUniversity(string name);
        List<Faculty> GetFaculties(string name);
        List<DBOFaculty> GetDBOFaculty(string name);
        Address GetUniversityAdress(string name);
        List<Student> GetStudents(int id);
        Dean GetDean(int id);
        Address GetAddress(int id);

        //List<DBOUniversity> CreatedDBOUniversity(List<University> universities);
        //int GetDBOIDUniversity(List<DBOUniversity> dBOUniversities, University university);
        //List<DBOFaculty> CreatedDBOFaculty(List<University> universities);
        //int GetDBOFacultyAddressID(List<DBOFaculty> dBOFaculties, Faculty faculty);
        //int GetDBOUniversityAddressID(List<DBOUniversity> dBOUniversities, University university);
        

        List<DBOUniversity> CreatedDBOUniversities(List<University> universities);
        List<DBOFaculty> CreatedDBOFaculties(List<University> universities);
        List<DBOAddress> CreatedDBOAddress(List<University> universities);
        List<DBODean> CreatedDBODean(List<University> universities);
        List<DBOStudent> CreatedDBOStudent(List<University> universities);
        ListDBOObject GetListDBOObjects(List<University> universities);
    }
}
