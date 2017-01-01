using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_Alistirma
{
    class anakonda
    {
        public anakonda()
        {
            MessageBox.Show("Anakonda constructor çalıştı");
        }
        public anakonda(String s) :this ()
        {
            MessageBox.Show("Anakonda parametreli çalıştı");
        }
    }
}
