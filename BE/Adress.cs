using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Adress
    {
        private string _street;
        private int _nHouse;
        private string _city;

        public Adress(string street, int nHouse, string city)
        {
            _street = street;
            _nHouse = nHouse;
            _city = city;
        }

        public override string ToString()
        {
            return "City: " + _city +
                " Street: " + _street +
                " House Number: " + _nHouse;
        }
    }
}
