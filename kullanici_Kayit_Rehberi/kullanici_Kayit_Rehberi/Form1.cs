using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanici_Kayit_Rehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            label4.Text = ad_Soyad.Text;
            label7.Text = telefon_No.Text;
            label10.Text = il.Text;
            label13.Text = adres_Kutusu.Text;
            
        }

    }
}
