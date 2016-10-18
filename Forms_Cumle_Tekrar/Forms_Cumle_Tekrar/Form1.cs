using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Cumle_Tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            string cumle;
            cumle = textBox.Text;
            for (int i = 1; i <= 10; i++)
            {
                label2.Text = label2.Text + i + ". " + cumle + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            
        }
    }
}
