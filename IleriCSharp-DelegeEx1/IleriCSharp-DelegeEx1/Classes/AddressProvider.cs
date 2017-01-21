using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriCSharp_DelegeEx1.Classes
{
    public delegate bool KalemGönder(List<CustomerAddress> ListOfAddresses);
    public delegate bool KupaGönder(List<CustomerAddress> ListOfAddresses);

    public class AddressProvider
    {
        public KalemGönder KalemGonderDelege;
        public KupaGönder KupaGonderDelege;
        public List<CustomerAddress> GetAddressesNewProspects()
        {
            List<CustomerAddress> ListOfAddresses = new List<CustomerAddress>();

            //add addresses of prospects
            CustomerAddress tempCustomerAddress = new CustomerAddress("EvAdresi", "Kavakli", "Turkey");
            ListOfAddresses.Add(tempCustomerAddress);

            PenCompany _penCompany = new PenCompany();
            KalemGonderDelege = _penCompany.SendPens;

            CupCompany _cupCompany = new CupCompany();
            KupaGonderDelege = _cupCompany.SendCoffeeCups;

            return ListOfAddresses;
        }

        //public bool DelegeyiCalistir(DoAfterGetAddresses _delegeMethod)
        //{ 
        //    List<CustomerAddress> _customerAddress = GetAddressesNewProspects();

        //    bool basariliMi = _delegeMethod(_customerAddress);

        //    return basariliMi;
        //}

    }
}
