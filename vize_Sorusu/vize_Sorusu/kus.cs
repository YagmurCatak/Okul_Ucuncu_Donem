using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_Sorusu
{
    class kus : defter 
    {
        public kus()
            : this(45)
        {
            MessageBox.Show("ben kusum 5");
            kanat = "lav1";
        }
        public kus(long sonSinav):base ("ss")
        {
            kanat = "lav2";
            MessageBox.Show("BEN KUSUM 3");
        }
        string kanat;
        public void haberler()
        {
            MessageBox.Show("bu sınav çok kolay ");
        }
    }
}
