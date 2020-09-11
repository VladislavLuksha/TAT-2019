using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    [Serializable]
    public class DBOStudent
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int FacultyID { get; set; }
        public double AverageMark { get; set; }

    }
}
