using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosyal_Servis_Uyg
{
    class Program
    {
        static void Main(string[] args)
        {
            Sofor m_sofor =new Sofor();
            Kullanici m_kullanici = new Kullanici();

            m_sofor.Attach(m_kullanici);

            m_sofor.RotaDegistir();
            


        }
    }
}
