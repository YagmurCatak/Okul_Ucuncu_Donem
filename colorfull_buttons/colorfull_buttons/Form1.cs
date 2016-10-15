using System;
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
       
      

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            button.BackColor = Color.Orange;
            this.button.MouseHover -= new System.EventHandler(this.button_MouseHover);
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            
            button.BackColor = Color.Red;
          
        }

       
     
    }
}
