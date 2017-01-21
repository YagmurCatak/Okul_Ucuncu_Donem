using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriCSharp_DelegeEx1.Classes
{
    public class AddressProvider
    {
        public List<CustomerAddress> GetAddressesNewProspects()
        {
            List<CustomerAddress> ListOfAddresses = new List<CustomerAddress>();

            //add addresses of prospects


            return ListOfAddresses;
        }

        public bool DelegeyiCalistir(DoAfterGetAddresses _delegeMethod)
        { 
            List<CustomerAddress> _customerAddress = GetAddressesNewProspects();

            bool basariliMi = _delegeMethod(_customerAddress);

            return basariliMi;
        }
    }
}
