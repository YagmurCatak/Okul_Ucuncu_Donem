using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriCSharp_DelegeEx1.Classes
{
    public class PenCompany
    {
        public bool SendPens(List<CustomerAddress> ListOfAddresses)
        {
            //for each CustomerAddress send ball pen

            foreach (CustomerAddress item in ListOfAddresses)  
            {
                Console.WriteLine("Kalem " + item.m_name + " adresine yollandi");
            }

            return true;
        }
    }
}
