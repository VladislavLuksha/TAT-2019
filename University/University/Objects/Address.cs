using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    [Serializable]
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Building { get; set; }

        public Address() { }
        public Address(string street,string city,string building)
        {
            this.Street = street;
            this.City = city;
            this.Building = building;
        }

        public override bool Equals(object subject)
        {
            if (subject is Address)
            {
                Address addres = (Address)subject;
                return (this.Street == addres.Street && this.City == addres.City && this.Building == addres.Building);
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return this.Street + " " + this.City + " " + this.Building;
        }
    }
}
