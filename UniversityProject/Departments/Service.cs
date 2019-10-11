using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Service:Department
    {
        Head head;
        List<Accountant> accountants;
        int numberOfAccountant = 10;
        public Service(Address address, string name, Head head):base(address, name)
        { 
            this.head = head;
            accountants = new List<Accountant>();
        }

        public bool AddAccountant(Accountant accountant)
        {
            bool check = true;
            if (numberOfAccountant <= accountants.Count)
            {
                return false;
            }
            else
            {
                foreach (Accountant element in accountants)
                {
                    if (element?.Equals(accountant) == true)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    accountants.Add(accountant);
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
            return base.ToString() + " " + this.head.ToString();
        }
    }
}
