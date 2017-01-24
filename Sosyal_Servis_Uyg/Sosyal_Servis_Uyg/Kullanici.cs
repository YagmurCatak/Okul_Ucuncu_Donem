using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosyal_Servis_Uyg
{
    class Kullanici: Insan,IServisObserver
    {
       
        public void yeniRotaGeldi()
        {
            Console.WriteLine("yeni rota geldi");
        }
        
    }
}
