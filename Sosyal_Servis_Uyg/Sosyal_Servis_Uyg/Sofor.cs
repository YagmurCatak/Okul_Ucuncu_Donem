using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosyal_Servis_Uyg
{
    class Sofor:Insan
    {
        List<IServisObserver> Rotalar;
        SurucuBelgesi m_surucubelgesi;
        
        public Sofor()
        {
            Rotalar = new List<IServisObserver>();
        }

        public void RotaDegistir()
        {
            foreach (IServisObserver item in Rotalar)
            {
                item.yeniRotaGeldi();
            }
        }

        public void DurakDegistir(string time)
        {
            
        }

        public void Attach(IServisObserver Kullanici)
        {
            Rotalar.Add(Kullanici);
        }
    }
}
