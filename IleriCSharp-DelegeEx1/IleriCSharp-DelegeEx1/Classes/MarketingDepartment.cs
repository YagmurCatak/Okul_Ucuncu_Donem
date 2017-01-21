using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriCSharp_DelegeEx1.Classes
{
    public class MarketingDepartment
    {
        public bool YeniBirKampanyaYurut(double butce)
        {
            bool basariliMi = false;

            AddressProvider _addressProvider = new AddressProvider();

            List<CustomerAddress> _customerAddresses = _addressProvider.GetAddressesNewProspects();

            if (butce < 10000)
            {
                PenCompany _penCompany = new PenCompany();
                basariliMi = _penCompany.SendPens(_customerAddresses);
            }
            else
            {
                CupCompany _cupCompany = new CupCompany();
                basariliMi = _cupCompany.SendCoffeeCups(_customerAddresses);
            }

            return basariliMi;
        }
    }
}
