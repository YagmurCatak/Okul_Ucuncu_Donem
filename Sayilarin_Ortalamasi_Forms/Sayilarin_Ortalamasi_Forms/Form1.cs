﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void enter_Click(object sender, EventArgs e)
        {
            Sonuc.Visible = true;
            int Sayi; 
            if (Sayi == 0)
            {
                Toplam = 0;
                Ortalama = 0; 
            }
            else
            {
                Toplam = Toplam + Sayi;
                i++;
                Ortalama = Toplam / i;
                Sonuc.TabIndex = Ortalama;
            }
        }
        int Ortalama, Toplam, i;
        private void Form1_load(object sender, EventArgs e)
        {
            Sonuc.Visible = false;
            i = 0;
            Ortalama = 0;
            Toplam = 0;
       
        }

       
    }
}
