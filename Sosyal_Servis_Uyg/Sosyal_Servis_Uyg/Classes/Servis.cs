using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sosyal_Servis_Uyg.Interfaces;

namespace Sosyal_Servis_Uyg.Classes
{
    class Servis
    {
        public Servis(String plaka, Rota rota)
        {
            m_plaka = plaka;
            m_rota = rota;
            m_kullanicilar = new List<IServisObserver>();
        }

        private String m_plaka;
        private List<IServisObserver> m_kullanicilar;
        private Rota m_rota;

        public void Plaka(String plaka)
        {
            m_plaka = plaka;
        }

        public String Plaka()
        {
            return m_plaka;
        }

        public void Rota(Rota yeniRota)
        {
            m_rota = yeniRota;
            foreach (IServisObserver item in m_kullanicilar)
            {
                item.yeniRotaGeldi(yeniRota);
            }
        }

        public void Attach(IServisObserver item)
        {
            m_kullanicilar.Add(item);
        }
    }
}
