using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatten
{
    class Program
    {
        static void Main(string[] args)
        {


            Ogrenci Student = new Ogrenci();
            Anne anne = new Anne();
            Baba baba = new Baba();
            Ogretmen ogretmen = new Ogretmen();
            Teyze teyze = new Teyze();

            Student.Attach(anne);
            Student.Attach(baba);
            Student.Attach(ogretmen);
            Student.Attach(teyze);

            Student.Ders_As();
            
            
            
        }
    }
}
