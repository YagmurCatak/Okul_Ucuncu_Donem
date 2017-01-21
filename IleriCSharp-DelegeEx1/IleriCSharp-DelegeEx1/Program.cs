using IleriCSharp_DelegeEx1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriCSharp_DelegeEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingDepartment _marketingDep = new MarketingDepartment();
            _marketingDep.YeniBirKampanyaYurut(15000);
        }
    }
}
