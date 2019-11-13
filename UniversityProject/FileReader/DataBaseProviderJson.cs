using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace University
{
    class DataBaseProviderJson:IDBProvider
    {
        const string nameFile = "stud.xml";

        public List<DBOAddress> GetAddresses()
        {
            throw new NotImplementedException();
        }

        public List<DBODean> GetDean()
        {
            throw new NotImplementedException();
        }

        public List<DBOFaculty> GetFaculties()
        {
            throw new NotImplementedException();
        }


        public List<DBOStudent> GetStudents()
        {
            List<DBOStudent> dBOStudents = new List<DBOStudent>();
            string path = @"C:\Users\User\Proga\c#\project(course)\University\University\FileReader\DataBaseProviderJson.cs";
            using (StreamReader fileStream = new StreamReader(path, Encoding.UTF8))
            {
                string text = fileStream.ReadToEnd();
                // dBOStudents = JsonConvert.DeserializeObject<List<DBOStudent>>(text);
                // dBOStudents.Add(dBOStudent);
            }
            return dBOStudents;
        }

        public List<DBOUniversity> GetUniversities()
        {
            throw new NotImplementedException();
        }
    }
}
