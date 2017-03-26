using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sosyal_Servis_Uyg.Classes;

namespace Sosyal_Servis_Uyg
{
    class Program
    {
        static void Main(string[] args)
        {
            Durak _durak1 = new Durak("IskeleYolu", DateTime.Now);
            Durak _durak2 = new Durak("HalkEvi", DateTime.Now);
            Rota _rota1 = new Rota("Rota1");
            _rota1.DurakEkle(_durak1);
            _rota1.DurakEkle(_durak2);

            Servis _servis1 = new Servis("41E7922", _rota1);

            Sofor _sofor1 = new Sofor("Metin", "Catak", 50, _servis1);

            Kullanici _kullanici1 = new Kullanici("Tunahan");
            Kullanici _kullanici2 = new Kullanici("Yagmur");
            _servis1.Attach(_kullanici1);
            _servis1.Attach(_kullanici2);

            //Yeni Rota
            Durak _durak3 = new Durak("Garajlar", DateTime.Now);
            Rota _rota2 = new Rota("Rota2");
            _rota2.DurakEkle(_durak3);
            _rota2.DurakEkle(_durak2);

            _sofor1.RotaDegistir(_rota2);

            _sofor1.DurakZamanDegistir(_durak3, DateTime.Now);


        }
    }
}
