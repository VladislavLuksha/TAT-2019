using System;
using System.Collections.Generic;

namespace University
{
    class Institute:Department
    {
        List<Employee> employees;
        Manager manager;
        int numberOfEmployee = 10;
        public Institute(Address adress, string name, Manager manager):base(adress, name)
        {
            this.manager = manager;
            employees = new List<Employee>();
        }

        public bool AddEmploees(Employee employee)
        {
            bool check = true;
            if (numberOfEmployee <= employees.Count)
            {
                return false;
            }
            else
            {
                foreach (Employee element in employees)
                {
                    if (element?.Equals(employee) == true)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    employees.Add(employee);
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
            return base.ToString()+ " " + this.manager.ToString();
        }
    }
}
