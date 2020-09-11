using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class DataBaseProviderJson
    {
        string massiveObject;

        public void SerelizationUniversityInFile(List<University> universities)
        {
            using (FileStream fstream = new FileStream(@"C:\Users\User\Proga\c#\project(course)\University\University\FilesJson\file.json", FileMode.OpenOrCreate))
            {
                byte[] arrayUniversities;
                massiveObject = JsonConvert.SerializeObject(universities);
                arrayUniversities = System.Text.Encoding.Default.GetBytes(massiveObject);
                fstream.Write(arrayUniversities, 0, arrayUniversities.Length);
            }
        }

        public List<University> DeselizationUniversityFromFile()
        {
            List<University> universities = new List<University>();
            using (FileStream fstream = File.OpenRead(@"C:\Users\User\Proga\c#\project(course)\University\University\FilesJson\file.json"))
            {
                universities = JsonConvert.DeserializeObject<List<University>>(massiveObject);
            }
            return universities;
        }
    }
}



