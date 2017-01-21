using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriCSharp_DelegeEx1.Classes
{
    public class CustomerAddress
    {
        public CustomerAddress(string _name, string _street, string _country)
        {
            m_name = _name;
            m_street = _street;
            m_country = _country;
        }

        public string m_name { get; set; }
        public string m_street { get; set; }
        public string m_country { get; set; }
    }
}
