using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace this_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             Cocuk b = new Cocuk(3,4);
        }
        class Dede
        {
            public string ad;
            public string soyAd;
            public string gozRengi;
            public int yas;
            public int kilo;


            public Dede()
                : this("a", "b")
            {
                this.ad = "Şakir";
                MessageBox.Show(this.ad);

            }
            public Dede(string GozRengi, string SoyAd)
                : this(1, 2)
            {
                GozRengi = this.gozRengi = "Mavi";
                SoyAd = this.soyAd = "Coskun";

                MessageBox.Show(this.gozRengi);
                MessageBox.Show(this.soyAd);
            }
            public Dede(int yas, int kilo)
            {
                this.yas = yas;
                this.kilo = kilo;

                MessageBox.Show(Convert.ToString(this.yas));
                MessageBox.Show(Convert.ToString(this.kilo));
            }
        }

        class Baba : Dede
        {
            public Baba()
                : this(8, 3)
            {
                this.ad = "Haydar";
                MessageBox.Show(this.ad);
            }
            public Baba(string GozRengi, string SoyAd)
                : base(3, 5)
            {
                GozRengi = this.gozRengi = "Ela";
                SoyAd = this.soyAd = "Dümen";

                MessageBox.Show(this.gozRengi);
                MessageBox.Show(this.soyAd);
            }
            public Baba(int Yas, int Kilo)
                : this("a", "b")
            {
                Yas = this.yas = 30;
                Kilo = this.kilo = 60;

                MessageBox.Show(Convert.ToString(this.yas));
                MessageBox.Show(Convert.ToString(this.kilo));
            }

        }

        class Cocuk : Baba
        {

            public Cocuk()
                : this(3, 4)
            {
                this.ad = "Hakkı";
                MessageBox.Show(this.ad);
            }
            public Cocuk(string GozRengi, string SoyAd)
                : base("a", "b")
            {
                GozRengi = this.gozRengi = "Kahverengi";
                SoyAd = this.soyAd = "Devrim";

                MessageBox.Show(this.gozRengi);
                MessageBox.Show(this.soyAd);
            }
            public Cocuk(int Yas, int Kilo)
                : this("a", "b")
            {
                Yas = this.yas = 60;
                Kilo = this.kilo = 80;

                MessageBox.Show(Convert.ToString(this.yas));
                MessageBox.Show(Convert.ToString(this.kilo));
            }
        }
    }
}
