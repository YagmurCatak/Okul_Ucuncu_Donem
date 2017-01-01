using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_Sorusu
{
    class aslan:defter 
    {
        string yorunge = "yapma be";
        long sekil = 360;

        public aslan():this("yagmur")
        {
            MessageBox.Show("aslan4");
        }
        public aslan(string elips):base("tugce")
        {
            MessageBox.Show("aslan2");
        }
    }
}
