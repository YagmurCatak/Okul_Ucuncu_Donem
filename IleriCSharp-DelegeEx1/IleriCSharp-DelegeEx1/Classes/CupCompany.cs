using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriCSharp_DelegeEx1.Classes
{
    public class CupCompany
    {
        public bool SendCoffeeCups(List<CustomerAddress> ListOfAddresses)
        {
            //for each CustomerAddress send coffee cup
            foreach (CustomerAddress item in ListOfAddresses)
            {
                Console.WriteLine("Kupa " + item.m_name + " adresine yollandi");
            }

            return true;
        }
    }
}
