using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_Alistirma
{
    class Temsilciler
    {
        public delegate void MetotTemsilcisi(int a,int b );

        public static void Toplama(int a, int b)
        {
            Console.WriteLine("{0}+{1} = {2}", a,b ,a+b);
        }

        public static void Cikarma(int a, int b)
        {
            Console.WriteLine("{0}-{1} = {2}", a, b, a - b);
        }

        public static void Carpma(int a, int b)
        {
            Console.WriteLine("{0}*{1} = {2}", a, b, a * b);
        }

        public static void Main()
        {
            MetotTemsilcisi temsilci = null;

            temsilci += new MetotTemsilcisi(Toplama);
            temsilci += new MetotTemsilcisi(Cikarma);
            temsilci += new MetotTemsilcisi(Carpma);
            temsilci -= new MetotTemsilcisi(Cikarma);
            temsilci(5,3);

            Console.WriteLine("***");

           temsilci -= new MetotTemsilcisi(Cikarma);
            temsilci(6, 4);

        }
       
    }
}
