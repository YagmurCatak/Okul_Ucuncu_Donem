using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatten
{
    class Ogrenci
    {
        List<Observer> Gozlemciler;

        public Ogrenci()
        {
            Gozlemciler = new List<Observer>();
        }

        public void Ders_As()
        {
            foreach (Observer item in Gozlemciler)
            {
                item.HaberVer();
            }
        }
        public void Attach(Observer gozlemci)
        {
            Gozlemciler.Add(gozlemci);
        }
    }
}
