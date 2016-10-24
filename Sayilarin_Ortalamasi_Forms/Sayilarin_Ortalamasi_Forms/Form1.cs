using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayilarin_Ortalamasi_Forms
{
    public partial class Form1 : Form
    {
        public int Ortalama, Toplam, i;
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void enter_Click(object sender, EventArgs e)
        {
            Sonuc.Visible = true;
            int Sayi;
            Sayi = Convert.ToInt32(textBox1.Text);
            if (Sayi == 0)
            {
                Ortalama = Toplam / i;
                Sonuc = Ortalama.ToString();
            }
            else
            {
                Toplam = Toplam + Sayi;
                i++;
                
            }
        }
        
   
    }
}
