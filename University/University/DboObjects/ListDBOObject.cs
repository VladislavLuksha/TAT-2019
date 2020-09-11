using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class ListDBOObject
    {
        public List<DBOUniversity> dBOUniversities { get; set; }
        public List<DBOFaculty> dBOFaculties { get; set; }
        public List<DBOAddress> dBOAddresses { get; set; }
        public List<DBODean> dBODeans { get; set; }
        public List<DBOStudent> dBOStudents { get; set; }

    }
}
