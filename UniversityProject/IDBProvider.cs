using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface IDBProvider
    {
        List<DBOStudent> GetStudents();
        List<DBOFaculty> GetFaculties();
        List<DBOAddress> GetAddresses();
        List<DBOUniversity> GetUniversities();
        List<DBODean> GetDean();
    }
}
