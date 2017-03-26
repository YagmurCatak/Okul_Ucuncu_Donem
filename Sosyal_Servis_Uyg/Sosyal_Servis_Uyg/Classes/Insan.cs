using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosyal_Servis_Uyg.Classes
{
    class Insan
    {
        public Insan()
        {
            /*EMPTY*/
        }

        private string m_name;
        private string m_surname { get; set; }
        private UInt32 m_yas { get; set; }
        private Servis m_servis { get; set; }

        //Name-Setter function
        public void SetName(string name)
        {
            m_name = name;   
        }

        //Name-Getter function
        public string GetName()
        {
            return m_name;
        }

        public void SetSurname(string surname)
        {
            m_surname = surname;
        }

        public string GetSurname()
        {
            return m_surname;
        }

        public void SetYas(UInt32 yas)
        {
            m_yas = yas;
        }

        public UInt32 GetYas()
        {
            return m_yas;
        }

        public void SetServis(Servis service)
        {
            m_servis = service;
        }

        public Servis GetServis()
        {
            return m_servis;
        }

    }
}
