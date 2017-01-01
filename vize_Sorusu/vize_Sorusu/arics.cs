using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_Sorusu
{
    class arics:kus
    {
        public int vizviz;

        public arics(): base()
        {
            vizviz = 12;
            MessageBox.Show("ari8");
            igne = 56;
        }
        public arics(string crazi):this()
        {
            vizviz = 48;
            MessageBox.Show("ari0");
            igne = 82;
            MessageBox.Show("ari2");
        }
        public void haberler()
        {
            base.haberler();
            MessageBox.Show("bu sınavdan 100 alınır");
            base.haberler();
        }
        int igne;
    }
}
