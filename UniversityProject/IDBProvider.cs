using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface IDBProvider
    {
        List<Student> GetStudents();
        List<Faculty> GetFaculties();
        List<Address> GetAddresses();
        List<University> GetUniversities();
        List<int> IDfaculty();
        List<int> IDStudent();
    }
}
