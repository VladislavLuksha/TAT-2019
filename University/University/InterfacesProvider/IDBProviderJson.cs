using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface IDBProviderJson
    {
        void SerelizationUniversityInFile(List<University> universities);
        List<University> DeselizationUniversityFromFile();
    }
}
