using System;
using System.Collections.Generic;


namespace University
{
    [Serializable]
    public class University
    {
        public string Name { get; set; }
        public Address Adress { get; set; }
        int maxDepartment = 10;
        public List<Department> departments { get; set; }

        public University() { departments = new List<Department>(); }
        public University(string name, Address adress)
        {
            this.Name = name;
            this.Adress = adress;   
        }

        public bool AddDepartment(Department department)
        {
            bool check = true;
            if (departments.Count >= 10)
            {
                return false;
            }
            else
            {
                foreach (Department listElements in departments)
                {
                    if (listElements?.Equals(department) == true)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    if(department is Faculty)
                    {
                        (department as Faculty).myEvent += PrintMessage;     
                    }
                    departments.Add(department);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            return this.Name + " " + this.Adress;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
