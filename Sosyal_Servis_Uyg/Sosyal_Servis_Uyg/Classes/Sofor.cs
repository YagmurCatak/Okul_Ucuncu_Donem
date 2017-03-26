using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sosyal_Servis_Uyg.Interfaces;

namespace Sosyal_Servis_Uyg.Classes
{
    class Sofor : Insan
    {
        private SurucuBelgesi m_surucubelgesi;
        
        public Sofor(String name, String surName, UInt32 yas, Servis servis)
        {
            this.SetName(name);
            this.SetSurname(surName);
            this.SetYas(yas);
            this.SetServis(servis);
        }

        public void RotaDegistir(Rota yeniRota)
        {
            this.GetServis().Rota(yeniRota);
        }

        public void DurakZamanDegistir(Durak durak, DateTime time)
        {
            
        }
    }
}
