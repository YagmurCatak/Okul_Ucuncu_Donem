using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_Sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kus kus = new kus();
            defter ari = new arics("ss");
            defter aslan = new aslan();
            listele(kus);
            listele(aslan);
            listele(ari);
            //ari.haberler();
        }
        public void listele( defter a)
       {
           if (a is defter)
           {
               MessageBox.Show("bu sınav zor");
           }
           if (a is arics)
           {
               MessageBox.Show("bu sınav kolay");
           }
           if (a is aslan)
           {
               MessageBox.Show("kim demiş zor diye");
           }
           if (a is kus)
           {
               MessageBox.Show("aslında çok kolay");
           }
       }
      
    }
}
