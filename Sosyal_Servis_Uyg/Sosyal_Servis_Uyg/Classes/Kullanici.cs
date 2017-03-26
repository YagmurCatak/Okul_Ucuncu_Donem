using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sosyal_Servis_Uyg.Interfaces;

namespace Sosyal_Servis_Uyg.Classes
{
    class Kullanici: Insan,IServisObserver
    {
        public Kullanici(string name)
        {
            this.SetName(name);
        }
       
        public void yeniRotaGeldi(Rota yeniRota)
        {
            Console.WriteLine("yeni rota geldi" + yeniRota.GetRotaName());
        }

        public void yeniDurakSaati(DateTime zaman)
        {
            Console.WriteLine("yeni saat ");
        }
        
    }
}
