﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorfull_buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button.BackColor = Color.Chocolate;
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

            button.BackColor = Color.Blue;

        }
    }
}
