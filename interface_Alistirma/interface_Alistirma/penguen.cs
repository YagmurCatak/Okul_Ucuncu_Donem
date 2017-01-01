using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_Alistirma
{
    class penguen : magma
    {
        public penguen() 
        {
            MessageBox.Show("penguen constructor çalıştı");
        }
        public penguen(long sayi)
        {
            MessageBox.Show("Penguen parametreli çalıştı");
        }
    }
}
