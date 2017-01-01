using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_Alistirma
{
    class saturn : anakonda , ucak
    {
        public saturn()
        {
            MessageBox.Show("Saturn constructor calisti");
        }
        public saturn(long a)
        {
            MessageBox.Show("Saturn parametreli calisti");
        }
        public int listele()
        {
            MessageBox.Show("calıstı");
            return 0;
        }
        public void hesapla()
        {
        }
    }
}
