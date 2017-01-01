using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memeliler
{
    class Memeliler
    {
        public int kalp;
        public string kan, dolasim;

        public Memeliler()
        { }
        public Memeliler(int kalp, string kan, string dolasim)
        {
            MessageBox.Show(kalp + " ");
            MessageBox.Show(kan + " ");
            MessageBox.Show(dolasim + " ");
        }
    }
}
