using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_Alistirma
{
    class magma : anakonda
    {
        public magma() :this (true)
        {
            MessageBox.Show("Magma constructor çalıştı");
        } 
        public magma(bool kontrol): base ("t")
        {
            MessageBox.Show("Magma parametreli çalıştı");
        }
    }
}
