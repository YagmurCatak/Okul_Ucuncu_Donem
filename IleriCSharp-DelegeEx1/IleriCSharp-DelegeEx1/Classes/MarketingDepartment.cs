using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriCSharp_DelegeEx1.Classes
{
    //donus tipi bool olan ve içerisine CustomerAddress Listesi alan bütün fonksiyonları delege edebilir.
    public delegate bool DoAfterGetAddresses(List<CustomerAddress> ListOfAddresses);


    public class MarketingDepartment
    {
        public bool YeniBirKampanyaYurut(double butce)
        {
            DoAfterGetAddresses ToDoAfterAddresses;

            bool basariliMi = false;

            AddressProvider _addressProvider = new AddressProvider();

            if (butce < 10000)
            {
                PenCompany _penCompany = new PenCompany();
                ToDoAfterAddresses = _penCompany.SendPens;
                //basariliMi = _penCompany.SendPens(_customerAddresses);
            }
            else
            {
                CupCompany _cupCompany = new CupCompany();
                ToDoAfterAddresses = _cupCompany.SendCoffeeCups;
                //basariliMi = _cupCompany.SendCoffeeCups(_customerAddresses);
            }

            basariliMi = _addressProvider.DelegeyiCalistir(ToDoAfterAddresses);

            return basariliMi;
        }
    }
}
