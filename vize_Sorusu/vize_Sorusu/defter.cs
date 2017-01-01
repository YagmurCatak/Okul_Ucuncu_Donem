using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_Sorusu
{
    class defter
    {
        public string yaz;
        public string ciz;

        public defter()
        {
            yaz = "paymak yok";
            sil = "dis yok";
            MessageBox.Show("ben defterim1");
            ciz = "kol var";
        }
        public string ele(string el)
        {
            return el;
        }

        public defter(string yas):this()
        {
            MessageBox.Show("merhaba bilgisayar mühendisliği");
            yaz = "parmak var";
            sil = "dis var";
            ciz = "kolyok";
            MessageBox.Show("bendefterim2");
        }
        private string sil;
    }
}
