using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Address
    {
        string street;
        string city;
        string building;

        public Address() { }
        public Address(string street,string city,string building)
        {
            this.street = street;
            this.city = city;
            this.building = building;
        }

        public override bool Equals(object subject)
        {
            if (subject is Address)
            {
                Address addres = (Address)subject;
                return (this.street == addres.street && this.city == addres.city && this.building == addres.building);
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return this.street + " " + this.city + " " + this.building;
        }
    }
}
