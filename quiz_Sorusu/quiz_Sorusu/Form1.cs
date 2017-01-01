using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_Sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            universite y = new universite();
            y.metod1();
            y.metod2();
            personel p = new personel("faruk");
            personel n = new personel();

        }
        public interface insan
        {
            void metod1();
            void metod2();

        }
        public class universite : insan
        {
            string ad;
            public void metod1()
            {
                MessageBox.Show("yagmur");

            }


            public void metod2()
            {

                MessageBox.Show("seda");
            }

        }
        public class personel : universite
        {
            string ad;
            public personel()
                : this("tr")
            {
                this.ad = "fr ";
                MessageBox.Show(this.ad);
            }
            public personel(string ad)
            {
                this.ad = ad;
                MessageBox.Show(this.ad);
            }

        }
        public class hoca : personel
        {



        }
        public class ogrenci : hoca
        {



        }
    }
}
