using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sosyal_Servis_Uyg.Classes;

namespace Sosyal_Servis_Uyg.Interfaces
{
    interface IServisObserver
    {
        void yeniRotaGeldi(Rota yeniRota);
    }
}
