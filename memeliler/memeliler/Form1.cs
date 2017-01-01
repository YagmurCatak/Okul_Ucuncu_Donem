using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memeliler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kedi kedi = new Kedi(10, 5,"van");
            Memeliler kedi1= new Memeliler(2, "temiz", "ic");
           
            Kopek kopek = new Kopek(5, 10, "pug");
            Memeliler kopek1 = new Memeliler(4, "temiz", "ic");

            Tavsan tavsan = new Tavsan(3,2,"Ingiliz");
            Memeliler tavsan1 = new Memeliler(2, "temiz", "ic");
           
        }
    }

    class Kedi : Memeliler
    {
        public int boy, agirlik;
        public string tur;
        public Kedi() { }
        public Kedi(int boy, int agirlik, string tur)
        {
            StringBuilder strMessageBox = new StringBuilder("Kedinin Boyu: " + boy + "\n" +
                                                            "Kedinin Agirligi: " + agirlik + "\n" +
                                                            "Kedinin Türü: " + tur);

            MessageBox.Show(strMessageBox.ToString());
        }
    }

    class Kopek : Memeliler
    {
        
        public int boy, agirlik;
        public string tur;
        public Kopek() { }
        public Kopek(int boy, int agirlik, string tur)
        {
            MessageBox.Show(boy + " ");
            MessageBox.Show(agirlik + " ");
            MessageBox.Show(agirlik + " ");
        }
    }

    class Tavsan : Memeliler
    {
        public int boy, agirlik;
        public string tur;
        public Tavsan() { }
        public Tavsan(int boy, int agirlik, string tur)
        {
           
            MessageBox.Show( boy +" ");
       
            MessageBox.Show(agirlik + " ");
       
            MessageBox.Show(tur + " ");
        }
    }

     class AnaKod
      {
          static void Ana()
          {
              Kedi kedi = new Kedi(10, 5,"van");
              Memeliler kedi1= new Memeliler(2, "temiz", "ic");
           
              Kopek kopek = new Kopek(5, 10, "pug");
              Memeliler kopek1 = new Memeliler(4, "temiz", "ic");

              Tavsan tavsan = new Tavsan(3,2,"Ingiliz");
              Memeliler tavsan1 = new Memeliler(2, "temiz", "ic");
          }
      }
}
