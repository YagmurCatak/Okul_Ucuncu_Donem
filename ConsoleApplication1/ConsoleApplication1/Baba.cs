using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Baba : Dede
    {
        public Baba() 
        {
            Console.WriteLine("Baba\n");

        }

        public override void Maas()
        {
            Console.WriteLine("Baba - Maas\n");
        }
    }
}
