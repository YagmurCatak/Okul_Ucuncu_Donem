using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosyal_Servis_Uyg.Classes
{
    class Durak
    {
        private String m_name;
        private DateTime  m_zaman;

        public Durak(String name, DateTime zaman)
        {
            m_name = name;
            m_zaman = zaman;
        }
        public void GetZaman(DateTime zaman)
        {
            m_zaman = zaman;
        }
        public DateTime SetZaman()
        { 
            return m_zaman;
        }
    }
}
