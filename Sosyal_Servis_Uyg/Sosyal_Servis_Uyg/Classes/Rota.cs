using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosyal_Servis_Uyg.Classes
{
    class Rota
    {
        private String m_rotaName;
        private List<Durak> m_duraklar;

        public Rota(String rotaName)
        {
            m_rotaName = rotaName;
            m_duraklar = new List<Durak>();
        }

        public String GetRotaName()
        {
            return m_rotaName;
        }

        public void DurakEkle(Durak durak)
        {
            m_duraklar.Add(durak);
        }

    }
}
