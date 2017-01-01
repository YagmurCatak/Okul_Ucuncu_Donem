using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_Alistirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         anakonda a = new anakonda();
         saturn s = new saturn();
         magma m = new magma();
         penguen p = new penguen();
         anakonda at = new magma();
         s.listele();
            
        }
    }
}
