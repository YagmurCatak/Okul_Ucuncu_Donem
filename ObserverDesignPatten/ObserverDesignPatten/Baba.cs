using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatten
{
    class Baba : Observer
    {
        public void HaberVer()
        {
            Console.WriteLine("okula gelmedi");
        }
    }
}
