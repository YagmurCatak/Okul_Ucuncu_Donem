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
            Kedi kedi = new Kedi();
            kedi.agirlik = 5;
            kedi.boy = 10;
            kedi.tur = "Van";
            kedi.kalp = 2;
            kedi.kan = "temiz";
            kedi.dolasim = "ic";

            Kopek kopek = new Kopek();
            kopek.agirlik = 5;
            kopek.boy = 10;
            kopek.tur = "pug";
            kopek.kalp = 2;
            kopek.kan = "temiz";
            kopek.dolasim = "ic";

            Tavsan tavsan = new Tavsan();
            tavsan.agirlik = 5;
            tavsan.boy = 10;
            tavsan.tur = "Ingiliz";
            tavsan.kalp = 2;
            tavsan.kan = "temiz";
            tavsan.dolasim = "ic";

            kedi.odacik();
            kedi.cesit();
            kedi.dolasim_türü();
            kedi.boy_olc();
            kedi.kilo_olc();
            kedi.turGoster();

            kopek.odacik();
            kopek.cesit();
            kopek.dolasim_türü();
            kopek.boy_olc();
            kopek.kilo_olc();
            kopek.turGoster();

            tavsan.odacik();
            tavsan.cesit();
            tavsan.dolasim_türü();
            tavsan.boy_olc();
            tavsan.kilo_olc();
            tavsan.turGoster();
        }
    }

    class Memeliler
    {
        public int kalp;
        public string kan, dolasim;

        public void odacik()
        {
            MessageBox.Show(kalp + " ");
        }
        public void cesit()
        {
            MessageBox.Show(kan+ " ");
        }
        public void dolasim_türü()
        {
            MessageBox.Show(dolasim + " ");
        }
    }

    class Kedi : Memeliler
    {
        public int boy, agirlik;
        public string tur;

        public void boy_olc()
        {
            MessageBox.Show(boy + " ");   
        }
        public void kilo_olc()
        {
            MessageBox.Show(agirlik + " ");    
        }
        public void turGoster()
        {
            MessageBox.Show(tur + " ");
        }
    }

    class Kopek : Memeliler
    {

        public int boy, agirlik;
        public string tur;

        public void boy_olc()
        {
            MessageBox.Show(boy + " ");
        }
        public void kilo_olc()
        {
            MessageBox.Show(agirlik + " ");
        }
        public void turGoster()
        {
            MessageBox.Show(agirlik + " ");
        }
    }

    class Tavsan : Memeliler
    {
        public int boy, agirlik;
        public string tur;

        public void boy_olc()
        {
           //Console.WriteLine("Boyu=" + boy);
            MessageBox.Show( boy +" ");
        }
        public void kilo_olc()
        {
            MessageBox.Show(agirlik + " ");
        }
        public void turGoster()
        {
            MessageBox.Show(tur + " ");
        }
    }

  /* class AnaKod
    {
        static void Ana()
        {

            Kedi kedi = new Kedi();
            kedi.agirlik = 5;
            kedi.boy = 10;
            kedi.tur = "Van";
            kedi.kalp = 2;
            kedi.kan = "temiz";
            kedi.dolasim = "ic";

            kedi.odacik();
            kedi.cesit();
            kedi.dolasim_türü();
            kedi.boy_olc();
            kedi.kilo_olc();
            kedi.turGoster();

            Kopek kopek = new Kopek();
            kopek.agirlik = 5;
            kopek.boy = 10;
            kopek.tur = "pug";
            kopek.kalp = 2;
            kopek.kan = "temiz";
            kopek.dolasim = "ic";

            kopek.odacik();
            kopek.cesit();
            kopek.dolasim_türü();
            kopek.boy_olc();
            kopek.kilo_olc();
            kopek.turGoster();

            Tavsan tavsan = new Tavsan();
            tavsan.agirlik = 5;
            tavsan.boy = 10;
            tavsan.tur = "Ingiliz";
            tavsan.kalp = 2;
            tavsan.kan = "temiz";
            tavsan.dolasim = "ic";

            tavsan.odacik();
            tavsan.cesit();
            tavsan.dolasim_türü();
            tavsan.boy_olc();
            tavsan.kilo_olc();
            tavsan.turGoster();
        }
    }*/
}
