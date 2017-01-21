using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriCSharp_DelegeEx1.Classes
{
    //donus tipi bool olan ve içerisine CustomerAddress Listesi alan bütün fonksiyonları delege edebilir.
    //public delegate bool DoAfterGetAddresses(List<CustomerAddress> ListOfAddresses);
        
    public class MarketingDepartment
    {
        public bool YeniBirKampanyaYurut(double butce)
        {
            bool basariliMi = false;

            AddressProvider _addressProvider = new AddressProvider();
            List<CustomerAddress> ListOfAddresses = _addressProvider.GetAddressesNewProspects();

            if (butce < 10000)
            {

                basariliMi = _addressProvider.KalemGonderDelege(ListOfAddresses);
            }
            else
            {

                basariliMi = _addressProvider.KupaGonderDelege(ListOfAddresses);
            }

            return basariliMi;
        }
    }
}
